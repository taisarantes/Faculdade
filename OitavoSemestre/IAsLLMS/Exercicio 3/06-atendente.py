import time
import math

# Inicialização fictícia do cliente de API (Substitua pela biblioteca oficial em produção)
# Exemplo padrão Mistral SDK v1: client = Mistral(api_key=os.environ["MISTRAL_API_KEY"])
class MockLLMClient:
    """Simulador de chamadas para permitir desenvolvimento e validação do fluxo do agente"""
    def chamar_api(self, config_etapa: dict, mensagens_historico: list) -> tuple:
        global CONTADOR_CHAMADAS_LLM
        CONTADOR_CHAMADAS_LLM += 1
        
        # Simula resposta baseada na última mensagem inserida pelo cliente
        ultima_msg = mensagens_historico[-1]["content"] if mensagens_historico else ""
        
        # Mock para a etapa de coleta
        if config_etapa["prompt"] == "coleta-v1":
            if "48219" in ultima_msg or "77310" in ultima_msg or "90455" in ultima_msg:
                return "[PRONTO_PARA_AVANCAR]", "stop"
            return "Sinto muito pelo transtorno. Você saberia me informar o número do pedido?", "stop"
        
        # Mock para a etapa de Raciocínio (Retorna estrutura estrita solicitada)
        elif config_etapa["prompt"] == "raciocinio-v1":
            return (
                "--- raciocínio ---\n"
                "A previsão era 02/09 e hoje é 08/09, prazo vencido há 6 dias.\n"
                "O sistema diz 'em transporte' e o cliente reclama do não recebimento.\n"
                "Categoria: entrega_atrasada. Urgência: alta.\n"
                "Abrir Chamado: SIM\n"
                "Categoria: entrega_atrasada\n"
                "Urgência: alta\n"
                "Ação: Acionar a transportadora RápidoLog emergencialmente."
            ), "stop"
            
        # Mock para a etapa de Redação Final
        elif config_etapa["prompt"] == "redacao-v1":
            return "Chamado registrado com sucesso. Você pode acompanhar pelo protocolo fornecido.", "stop"
            
        return "Erro de processamento", "length"

client_llm = MockLLMClient()


# =====================================================================
# MECANISMO DE BACKOFF EXPONENCIAL (Robustez Requisito 7)
# =====================================================================
def executar_chamada_com_retry(config_etapa: dict, historico: list, max_tentativas=3) -> str:
    """Executa a chamada à API aplicando backoff exponencial em caso de falha (Erro 429 ou timeouts)."""
    tentativa = 0
    while tentativa < max_tentativas:
        try:
            # Em código real, use try/except capturando erros HTTP da API (ex: mistralai.exceptions.MistralException)
            resposta, finish_reason = client_llm.chamar_api(config_etapa, historico)
            
            # Validação robusta de estouro de tokens exigida pelo requisito 7
            if finish_reason == "length":
                print(f"[AVISO ROBUSTEZ] Resposta truncada por falta de tokens (finish_reason='length'). Redefinindo limite.")
                return "Erro: O limite de tokens do modelo foi atingido antes da conclusão."
                
            return resposta
        except Exception as e:
            tentativa += 1
            if tentativa == max_tentativas:
                print("[ERRO CRÍTICO] Falha persistente na comunicação após múltiplas tentativas.")
                raise e
            tempo_espera = math.pow(2, tentativa) # 2s, 4s...
            print(f"[RETRY] Erro de conexão detectado ({e}). Aplicando backoff de {tempo_espera}s...")
            time.sleep(tempo_espera)


# =====================================================================
# LOGICA DO AGENT LOOP (while com orçamento - Requisito 7)
# =====================================================================
def executar_atendimento_completo(id_atendimento: int, mensagem_inicial_cliente: str):
    """Orquestra o loop interativo do agente cobrindo as 5 etapas estruturais."""
    
    # 1. Emissão obrigatória do carimbo de auditoria no log (Requisito 6.1)
    imprimir_carimbo_atendimento(id_atendimento)
    
    # Histórico de conversação estruturado da Etapa 1
    historico_coleta = [
        {"role": "system", "content": PROMPT_COLETA_TEXTO},
        {"role": "user", "content": mensagem_inicial_cliente}
    ]
    
    # Limites rígidos de controle operacional
    TETO_TURNOS_COLETA = 5
    TETO_PASSOS_AGENTE = 10
    
    passo_atual = 0
    numero_pedido_identificado = None
    relato_completo_cliente = mensagem_inicial_cliente
    
    print(f"Cliente: {mensagem_inicial_cliente}")
    
    # -----------------------------------------------------------------
    # LOOP DA ETAPA 1: Coleta e Conversação Interativa
    # -----------------------------------------------------------------
    turno_coleta = 0
    while turno_coleta < TETO_TURNOS_COLETA:
        resposta_bot = executar_chamada_com_retry(CONFIG_COLETA, historico_coleta)
        
        # Se a LLM emitiu a flag autônoma de encerramento da coleta
        if "[PRONTO_PARA_AVANCAR]" in resposta_bot:
            # Varre o histórico para extrair o número do pedido informado pelo cliente
            for msg in reversed(historico_coleta):
                if msg["role"] == "user":
                    # Busca sequências numéricas de 5 dígitos nos inputs
                    palavras = msg["content"].replace(".", "").replace("-", " ").split()
                    for p in palavras:
                        if p.isdigit() and len(p) == 5:
                            numero_pedido_identificado = p
                            break
                if numero_pedido_identificado:
                    break
            break
            
        print(f"Bot:     {resposta_bot}")
        
        # Simulação de interação real no terminal pelo usuário
        resposta_usuario = input("Cliente: ")
        historico_coleta.append({"role": "assistant", "content": resposta_bot})
        historico_coleta.append({"role": "user", "content": resposta_usuario})
        
        # Consolida o contexto do relato para enviar ao motor de raciocínio
        relato_completo_cliente += f" | {resposta_usuario}"
        turno_coleta += 1

    if not numero_pedido_identificado:
        print("[ENCERRAMENTO] Não foi possível coletar um número de pedido válido dentro do teto de turnos.")
        return

    # -----------------------------------------------------------------
    # LOOP PRINCIPAL DO AGENTE (Tomada de Decisão e Ferramentas)
    # -----------------------------------------------------------------
    while passo_atual < TETO_PASSOS_AGENTE:
        passo_atual += 1
        
        # ETAPA 2: Consulta de validação e dados reais do sistema
        print(f"\n>>> [AÇÃO AGENTE] Invocando ferramenta: consultar_pedido({numero_pedido_identificado})")
        dados_sistema = consultar_pedido(numero_pedido_identificado)
        print(f"<<< [OBSERVAÇÃO] Retorno do sistema: {dados_sistema}")
        
        if dados_sistema["status"] == "erro":
            print(f"Bot: {dados_sistema['mensagem']}")
            # Permite re-coleta direta: Solicita nova entrada e reinicia o fluxo
            novo_numero = input("Cliente (Informe o número correto): ")
            numero_pedido_identificado = novo_numero.strip()
            continue

        # ETAPA 3: Ativação Isolada do Chain of Thought (Raciocínio Dedicado)
        # O CoT entra aqui porque exige inferência lógica complexa sobre matrizes de dados estruturados
        contexto_analise = [
            {"role": "system", "content": PROMPT_RACIOCINIO_TEXTO},
            {"role": "user", "content": f"Data Atual: {HOJE}\nDados do Sistema: {dados_sistema}\nRelato do Cliente: {relato_completo_cliente}"}
        ]
        
        bloco_raciocinio = executar_chamada_com_retry(CONFIG_RACIOCINIO, contexto_analise)
        print(f"\n{bloco_raciocinio}\n")
        
        # Parseamento simples das flags de controle retornadas pelo CoT estruturado
        deve_abrir = "Abrir Chamado: SIM" in bloco_raciocinio
        
        # Extração de metadados para repassar à ferramenta de escrita se aprovado
        categoria_extraida = "entrega_atrasada" # Fallback/Exemplo do parseador
        for cat in CATEGORIAS:
            if cat in bloco_raciocinio:
                categoria_extraida = cat
                break

        if not deve_abrir:
            print("Bot: Verifiquei que seu pedido está dentro do prazo regulamentar. Não há necessidade de abertura de chamado.")
            break
            
        # ETAPA 4: Ferramenta de Escrita (Exige estritamente validação humana)
        print("-" * 50)
        print(f"Deseja autorizar a abertura de chamado para a categoria '{categoria_extraida}'?")
        print("-" * 50)
        confirmacao = input("Confirmar abertura? (sim/nao): ").strip().lower()
        
        if confirmacao not in ["sim", "s", "yes"]:
            print("Bot: Abertura cancelada conforme sua solicitação. Como posso ajudar em algo mais?")
            break
            
        # Execução segura da gravação de dados
        resultado_escrita = abrir_chamado(
            pedido=numero_pedido_identificado,
            categoria=categoria_extraida,
            urgencia="alta",
            descricao=relato_completo_cliente,
            acao_sugerida="Acionamento emergencial da malha de logística."
        )
        
        protocolo_gerado = resultado_escrita.get("protocolo")
        
        # ETAPA 5: Consulta Final (Garantia Read-After-Write)
        print(f"\n>>> [AÇÃO AGENTE] Validando consolidação: consultar_chamado({protocolo_gerado})")
        dados_confirmados = consultar_chamado(protocolo_gerado)
        print(f"<<< [OBSERVAÇÃO] Verificação de integridade no Banco: {dados_confirmados}")
        
        # Geração da Mensagem Final de Conclusão via prompt de Redação
        historico_redacao = [
            {"role": "system", "content": PROMPT_REDACAO_TEXTO},
            {"role": "user", "content": f"Chamado Confirmado no Sistema: {dados_confirmados}\nRaciocínio Prévio: {bloco_raciocinio}"}
        ]
        mensagem_final = executar_chamada_com_retry(CONFIG_REDACAO, historico_redacao)
        print(f"\nBot final: {mensagem_final}")
        break
        # Impressão mandatória da auditoria de consumo e performance ao encerrar
        print("\n" + "=" * 50)
        print("MÉTRICAS DE AUDITORIA DE EXECUÇÃO:")
        print(f"  Total de chamadas realizadas à API de LLM: {CONTADOR_CHAMADAS_LLM}")
        print(f"  Total de execuções de Ferramentas nativas: {CONTADOR_CHAMADAS_FERRAMENTAS}")
        print("=" * 50)