import os
from datetime import date

# =====================================================================
# CONFIGURAÇÃO DO AMBIENTE E DADOS (Conforme Enunciado)
# =====================================================================

HOJE = date(2026, 9, 8)  # Data fixa para reproducibilidade

PEDIDOS = {
    "48219": {"situacao": "em transporte",     "previsao": "2026-09-02",
              "transportadora": "RápidoLog",   "cliente": "Ana Souza"},
    "77310": {"situacao": "entregue",          "previsao": "2026-08-19",
              "transportadora": "RápidoLog",   "cliente": "Bruno Lima"},
    "90455": {"situacao": "aguardando coleta", "previsao": "2026-09-15",
              "transportadora": "TransBrasil", "cliente": "Ana Souza"},
    "31002": {"situacao": "em transporte",     "previsao": "2026-09-11",
              "transportadora": "TransBrasil", "cliente": "Célia Rocha"},
}

CHAMADOS = {}  # Será preenchido dinamicamente pela ferramenta de escrita

CATEGORIAS = ["entrega_atrasada", "endereco_errado", "produto_avariado",
              "duvida", "elogio"]

# Contadores globais para auditoria da entrega
CONTADOR_CHAMADAS_LLM = 0
CONTADOR_CHAMADAS_FERRAMENTAS = 0


# =====================================================================
# IMPLEMENTAÇÃO DAS FERRAMENTAS (TOOLS)
# =====================================================================

def consultar_pedido(numero: str) -> dict:
    """
    Busca o status e informações reais de um pedido no banco de dados.
    Deve ser usada sempre que o cliente informar um número de pedido válido.
    Não deve ser usada se o número do pedido não foi coletado.
    
    Se o pedido não existir, retorna um dicionário de erro estruturado.
    """
    global CONTADOR_CHAMADAS_FERRAMENTAS
    CONTADOR_CHAMADAS_FERRAMENTAS += 1
    
    # Tratamento de string para evitar erros de espaços
    numero_limpo = str(numero).strip()
    
    if numero_limpo in PEDIDOS:
        dados = PEDIDOS[numero_limpo]
        return {
            "status": "sucesso",
            "pedido": numero_limpo,
            "situacao": dados["situacao"],
            "previsao": dados["previsao"],
            "transportadora": dados["transportadora"],
            "cliente": dados["cliente"]
        }
    else:
        # Erro retornado como DADO para a LLM poder tratar e re-solicitar
        return {
            "status": "erro",
            "mensagem": f"Pedido {numero_limpo} não encontrado no sistema."
        }


def abrir_chamado(pedido: str, categoria: str, urgencia: str,
                  descricao: str, acao_sugerida: str) -> dict:
    """
    Ferramenta de ESCRITA. Registra uma reclamação ou solicitação no sistema.
    CRÍTICO: Exige estritamente a confirmação prévia do cliente antes de ser executada.
    
    Gera e retorna um protocolo único sequencial.
    """
    global CONTADOR_CHAMADAS_FERRAMENTAS
    CONTADOR_CHAMADAS_FERRAMENTAS += 1
    
    pedido_limpo = str(pedido).strip()
    
    # Validação robusta de categoria
    if categoria not in CATEGORIAS:
        return {
            "status": "erro",
            "mensagem": f"Categoria inválida. Escolha entre: {CATEGORIAS}"
        }
        
    # Geração de protocolo fictício (Ex: 2026-0001)
    ano_atual = HOJE.year
    proximo_id = len(CHAMADOS) + 1
    protocolo = f"{ano_atual}-{proximo_id:04d}"
    
    # Gravação no estado do sistema
    CHAMADOS[protocolo] = {
        "pedido": pedido_limpo,
        "categoria": categoria,
        "urgencia": urgencia,
        "descricao": descricao,
        "acao_sugerida": acao_sugerida,
        "data_abertura": str(HOJE)
    }
    
    # Log exigido pelo requisito 4
    print(f"\n[REGISTRO SISTEMA] Chamado criado com sucesso!")
    print(f"  Protocolo: {protocolo} | Pedido: {pedido_limpo}")
    
    return {
        "status": "sucesso",
        "protocolo": protocolo
    }


def consultar_chamado(protocolo: str) -> dict:
    """
    Ferramenta de verificação pós-escrita (Read-after-write).
    Busca os detalhes de um chamado gravado no sistema pelo seu número de protocolo.
    Garante que a operação de escrita foi consolidada com sucesso.
    """
    global CONTADOR_CHAMADAS_FERRAMENTAS
    CONTADOR_CHAMADAS_FERRAMENTAS += 1
    
    protocolo_limpo = str(protocolo).strip()
    
    if protocolo_limpo in CHAMADOS:
        chamado_dados = CHAMADOS[protocolo_limpo]
        return {
            "status": "sucesso",
            "protocolo": protocolo_limpo,
            "dados": chamado_dados
        }
    else:
        return {
            "status": "erro",
            "mensagem": f"Protocolo {protocolo_limpo} não encontrado no sistema."
        }
