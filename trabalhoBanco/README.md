# Sistema Bancário em C#

## Padrões de Design Aplicados

### Factory Method
Este padrão foi usado para criar diferentes tipos de contas bancárias. Em vez de instanciar diretamente um tipo de conta, foi criada uma classe abstrata `AccountFactory` e classes derivadas como `CurrentAccountFactory`, `SavingsAccountFactory` e `SalaryAccountFactory`. Cada uma dessas classes implementa o método `CreateAccount`, que cria o tipo de conta específico.

### Herança e Polimorfismo
A classe base `Account` tem propriedades e métodos comuns a todos os tipos de conta, como:
- **Propriedades**: número da conta, saldo
- **Métodos**: débito, crédito, transferência

As classes derivadas (`CurrentAccount`, `SavingsAccount`, `SalaryAccount`) sobrescrevem alguns métodos conforme necessário:
- O método `fazerPix` na conta salário não permite transações via PIX.
- O método `render` só funciona em contas que permitem rendimentos, como a poupança.

## Estrutura do Sistema

### Banco e Agência
A classe `Bank` é responsável por gerenciar clientes e agências (`Branch`), que por sua vez gerenciam as contas.

### Clientes
A classe `Client` guarda os dados dos clientes, como:
- Nome
- CPF
- Endereço
- Telefone

### Contas
As classes que herdam de `Account` implementam comportamentos específicos:
- `CurrentAccount`: Conta Corrente
- `SavingsAccount`: Conta Poupança
- `SalaryAccount`: Conta Salário

### Exemplo de Uso
No `Main`, cria-se um banco, uma agência e uma conta poupança. Em seguida, são feitos saques para demonstrar o funcionamento da limitação de saques gratuitos da conta poupança, além de mostrar a função de "virar o mês", que zera a contagem de saques.

## Melhorias Possíveis

1. **Validação de Dados**: Melhorar a verificação de entradas de dados, como impedir valores negativos ou nulos.
2. **Exceções**: Implementar tratamentos de exceção para falhas, como ao tentar sacar um valor maior que o saldo disponível.
3. **Interface Gráfica**: Atualmente, todas as interações são feitas via terminal. Uma evolução seria criar uma interface gráfica para tornar o sistema mais interativo.
4. **Testes Automatizados**: Adicionar testes para garantir que todas as funcionalidades estejam funcionando corretamente.

---

Este sistema tem uma base sólida e bem estruturada, aplicando importantes conceitos de **Programação Orientada a Objetos (POO)** e **padrões de projeto**.
