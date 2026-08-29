# =====================================================================
# CONFIGURAÇÃO DE VERSÕES E PARÂMETROS POR ETAPA (Requisito 6)
# =====================================================================

# ETAPA 1: Coleta (Conversa com humano -> Temperatura aceitável/desejável)
CONFIG_COLETA = {
    "versao": 1,
    "prompt": "coleta-v1",
    "modelo": os.environ.get("LLM_MODELO", "mistral-small-latest"),
    "parametros": {"temperature": 0.6, "max_tokens": 150},
}

# ETAPA 3: Raciocínio (Decisão sobre dados -> Variação aqui é DEFEITO)
CONFIG_RACIOCINIO = {
    "versao": 1,
    "prompt": "raciocinio-v1",
    "modelo": os.environ.get("LLM_MODELO", "mistral-small-latest"),
    "parametros": {"temperature": 0, "max_tokens": 600}, # Espaço para o CoT completo
}

# ETAPA 5: Redação Final (Texto para humano -> Variação aceitável)
CONFIG_REDACAO = {
    "versao": 1,
    "prompt": "redacao-v1",
    "modelo": os.environ.get("LLM_MODELO", "mistral-small-latest"),
    "parametros": {"temperature": 0.5, "max_tokens": 250},
}


# =====================================================================
# FUNÇÃO AUXILIAR DE LEITURA E IMPRESSÃO DO CARIMBO (Requisito 6.1)
# =====================================================================

def carregar_prompt_arquivo(nome_prompt: str) -> str:
    """Carrega o conteúdo do prompt a partir da pasta prompts/"""
    caminho = os.path.join("prompts", f"{nome_prompt}.md")
    try:
        with open(caminho, "r", encoding="utf-8") as f:
            return f.read()
    except FileNotFoundError:
        print(f"[ERRO CRÍTICO] Arquivo de prompt não encontrado: {caminho}")
        return ""


def imprimir_carimbo_atendimento(id_atendimento: int):
    """
    Imprime o carimbo unificado declarando a combinação exata de
    prompt x modelo x parâmetros para cada etapa da execução atual.
    """
    print(f"\n=== ATENDIMENTO {id_atendimento} ===")
    
    for etapa, config in [("coleta", CONFIG_COLETA), 
                          ("raciocinio", CONFIG_RACIOCINIO), 
                          ("redacao", CONFIG_REDACAO)]:
        
        print(f"  {etapa:<12} v{config['versao']}  "
              f"prompt={config['prompt']:<14}  "
              f"modelo={config['modelo']:<22}  "
              f"temp={config['parametros']['temperature']}")
    print("=" * 50 + "\n")


# =====================================================================
# CARREGAMENTO DOS CONTEÚDOS DOS PROMPTS
# =====================================================================
PROMPT_COLETA_TEXTO = carregar_prompt_arquivo(CONFIG_COLETA["prompt"])
PROMPT_RACIOCINIO_TEXTO = carregar_prompt_arquivo(CONFIG_RACIOCINIO["prompt"])
PROMPT_REDACAO_TEXTO = carregar_prompt_arquivo(CONFIG_REDACAO["prompt"])
