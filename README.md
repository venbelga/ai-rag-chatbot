# Chatbot Corporativo com IA Generativa (.NET)

Este projeto é um chatbot corporativo desenvolvido em .NET, utilizando
IA generativa com foco em arquitetura limpa (Clean Architecture).

## Objetivo

Fornecer respostas com base em documentos internos, reduzindo
alucinação e mantendo controle arquitetural.

## Tecnologias

* .NET
* Clean Architecture
* IA Generativa (LLM)
* Embeddings (futuro)
* RAG (futuro)

## Observações Importantes

Este sistema utiliza um modelo probabilístico, portanto:

* Nem toda resposta é garantidamente correta
* O sistema deve possuir mecanismos de fallback



\## Limitações Técnicas



Este sistema utiliza um LLM que possui:



\- Limite de tokens por requisição

\- Custo baseado em quantidade de tokens

\- Capacidade limitada de memória de contexto

\- Possibilidade de alucinação



\### Estratégias futuras para mitigação



\- Uso de RAG para limitar contexto

\- Resumo de histórico de conversas

\- Controle de tamanho de prompt

