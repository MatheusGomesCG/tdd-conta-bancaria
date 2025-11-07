# 🏦 Sistema de Conta Bancária - TDD

Projeto desenvolvido utilizando **Test-Driven Development (TDD)** para implementar um sistema simples de conta bancária em C# com .NET 8.0.

## 📋 Sobre o Projeto

Este projeto implementa uma classe `ContaBancaria` com operações básicas de depósito e saque, seguindo a metodologia TDD. Todos os recursos foram desenvolvidos através de testes unitários utilizando o framework xUnit.

### Funcionalidades Implementadas

- ✅ Criação de conta bancária com saldo inicial zero
- ✅ Depósito de valores positivos
- ✅ Saque de valores dentro do saldo disponível
- ✅ Validação de valores negativos e zero em depósitos
- ✅ Validação de saldo insuficiente em saques

## 🛠️ Tecnologias Utilizadas

- **C# / .NET 8.0**
- **xUnit** - Framework de testes unitários

## 📁 Estrutura do Projeto

```
Atividade-01-teste/
│
├── tdd-conta-bancaria/              # Projeto principal
│   ├── Models/
│   │   └── ContaBancaria.cs         # Classe da conta bancária
│   ├── Program.cs
│   └── tdd-conta-bancaria.csproj
│
├── tests/
│   └── ContaBancaria.Tests/         # Projeto de testes
│       ├── ContaBancariaTests.cs    # Testes unitários
│       └── ContaBancaria.Test.csproj
│
└── README.md
```

## 🚀 Como Executar o Projeto

### Pré-requisitos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) instalado

### Verificar instalação do .NET

```powershell
dotnet --version
```

### 1. Clonar o Repositório

```powershell
git clone https://github.com/MatheusGomesCG/tdd-conta-bancaria.git
cd Atividade-01-teste
```

### 2. Restaurar Dependências

```powershell
dotnet restore
```

### 3. Compilar o Projeto

```powershell
dotnet build
```

### 4. Executar os Testes

Para executar todos os testes unitários:

```powershell
cd tests\ContaBancaria.Tests
dotnet test
```

Ou executar direto da raiz do projeto:

```powershell
dotnet test tests\ContaBancaria.Tests\ContaBancaria.Test.csproj
```

### 5. Executar o Projeto Principal

```powershell
cd tdd-conta-bancaria
dotnet run
```

## 🧪 Testes Implementados

### Testes de Inicialização
- `NovaContaDeveComecarComSaldoInicialZero()` - Verifica se nova conta inicia com saldo zero
- `NovaContaNaoDeveComecarComSaldoInicialDiferenteDeZero()` - Garante que o saldo inicial não é diferente de zero

### Testes de Saque
- `SacarUmValorSuperiorAoSaldoDeveManterOSaldoInalterado()` - Verifica que não é possível sacar mais que o saldo disponível
- `SacarUmValorInferiorAoSaldoDeveReduzirOSaldoCorretamente()` - Verifica que o saque reduz o saldo corretamente

### Testes de Depósito
- `DepositarUmValorPositivoDeveAumentarOSaldo()` - Verifica que depósito aumenta o saldo
- `DepositarUmValorNegativoNaoDeveAlterarOSaldo()` - Garante que valores negativos não são aceitos
- `DepositarZeroNaoDeveAlterarOSaldo()` - Garante que depósito de zero não altera o saldo

## 💡 Metodologia TDD Aplicada

O projeto seguiu o ciclo TDD:

1. **🔴 Red** - Escrever um teste que falha
2. **🟢 Green** - Escrever o código mínimo para o teste passar
3. **🔵 Refactor** - Melhorar o código mantendo os testes passando

### Exemplo de Fluxo TDD:

```
Teste: NovaContaDeveComecarComSaldoInicialZero()
  ↓
Implementação: public ContaBancaria() { Saldo = 0; }
  ↓
Refatoração: Melhorias de código (se necessário)
```

## 📝 Classe ContaBancaria - API

### Propriedades

```csharp
public decimal Saldo { get; private set; }
```
- **Saldo**: Saldo atual da conta (somente leitura externa)

### Métodos

```csharp
public void Depositar(decimal valor)
```
- **Descrição**: Deposita um valor na conta
- **Parâmetro**: `valor` - Valor a ser depositado (deve ser maior que zero)
- **Comportamento**: Aumenta o saldo se o valor for positivo

```csharp
public void Sacar(decimal valor)
```
- **Descrição**: Saca um valor da conta
- **Parâmetro**: `valor` - Valor a ser sacado
- **Comportamento**: Reduz o saldo se houver saldo suficiente

## 🎯 Regras de Negócio

1. Uma nova conta sempre inicia com saldo **R$ 0,00**
2. Só é possível depositar valores **maiores que zero**
3. Só é possível sacar se houver **saldo suficiente**
4. Depósitos de valores negativos ou zero **não alteram o saldo**
5. Saques maiores que o saldo **não são executados**

## 👨‍💻 Autor

**Matheus Gomes**
- GitHub: [@MatheusGomesCG](https://github.com/MatheusGomesCG)

## 📄 Licença

Este projeto é de código aberto e está disponível para fins educacionais.

---

⭐ Se este projeto foi útil para você, considere dar uma estrela!
