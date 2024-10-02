# Relatório: Sistema de Gerenciamento de Pedidos de Lanchonete

## Objetivo do Sistema
Este sistema foi desenvolvido para gerenciar pedidos de uma lanchonete, onde os clientes podem personalizar hambúrgueres com ingredientes adicionais. Ele também notifica automaticamente as equipes de produção e montagem quando um pedido é feito ou alterado, utilizando os padrões de projeto **Decorator** e **Observer**.

## Padrão Decorator
O padrão **Decorator** foi aplicado para permitir a personalização dos hambúrgueres com ingredientes extras.

- **Interface IHamburguer**: Define os métodos `Descricao` (retorna a descrição do hambúrguer) e `Custo()` (retorna o valor total).
- **HamburguerSimples**: Representa um hambúrguer sem ingredientes extras, implementando a interface `IHamburguer`.
- **IngredienteDecorator**: Classe abstrata base para todos os decoradores, herdando de `IHamburguer` e armazenando o hambúrguer a ser decorado.
- **Decoradores Concretos**: Ingredientes como bacon e queijo são decoradores concretos, que adicionam custo e atualizam a descrição.

Exemplo: O decorador `Bacon` adiciona bacon ao hambúrguer, aumentando o custo e atualizando a descrição.

## Padrão Observer
O padrão **Observer** foi aplicado para notificar automaticamente as equipes de produção e montagem.

- **Pedido (Sujeito)**: Mantém uma lista de observadores e notifica-os sempre que o pedido é alterado.
- **MonitorProducao e MonitorMontagem (Observadores)**: Recebem notificações quando o pedido é criado ou atualizado. A equipe de produção é informada sobre os ingredientes, e a equipe de montagem é avisada quando o pedido está pronto.

## Estrutura do Código
1. O cliente faz o pedido de um hambúrguer base.
2. Ingredientes extras podem ser adicionados usando o padrão **Decorator**.
3. Quando o pedido é finalizado, o padrão **Observer** notifica as equipes da lanchonete.
4. A equipe de produção prepara os ingredientes e a equipe de montagem organiza o pedido para entrega.

## Possíveis Melhorias
- **Interface Gráfica**: Adicionar uma GUI para facilitar o uso do sistema.
- **Outros Produtos**: Permitir personalizações para bebidas, sobremesas e acompanhamentos.
- **Persistência de Dados**: Salvar pedidos em um banco de dados.
- **Notificações Melhores**: Implementar notificações mais eficientes, como sons ou mensagens instantâneas.
