using tdd_conta_bancaria.Models;

namespace ContaBancaria.Test;

public class ContaBancariaTests
{
    [Fact]
    public void NovaContaDeveComecarComSaldoInicialZero()
    {
        // Arrange
        var conta = new tdd_conta_bancaria.Models.ContaBancaria();

        // Act
        var saldoInicial = conta.Saldo;

        // Assert
        Assert.Equal(0, saldoInicial);
    }

    [Fact]
    public void NovaContaNaoDeveComecarComSaldoInicialDiferenteDeZero()
    {
        // Arrange
        var conta = new tdd_conta_bancaria.Models.ContaBancaria();

        // Act
        var saldoInicial = conta.Saldo;

        // Assert
        Assert.NotEqual(100, saldoInicial);
    }

    [Fact]
    public void SacarUmValorSuperiorAoSaldoDeveManterOSaldoInalterado()
    {
        // Arrange
        var conta = new tdd_conta_bancaria.Models.ContaBancaria();
        var saldoAntesDoSaque = conta.Saldo;

        // Act
        decimal valorASacar = saldoAntesDoSaque + 50;
        conta.Sacar(valorASacar);

        // Assert
        Assert.Equal(saldoAntesDoSaque, conta.Saldo);
    }

    [Fact]
    public void SacarUmValorInferiorAoSaldoDeveReduzirOSaldoCorretamente()
    {
        // Arrange
        var conta = new tdd_conta_bancaria.Models.ContaBancaria();
        conta.Depositar(100);
        var saldoAntesDoSaque = conta.Saldo;

        // Act
        decimal valorASacar = 50;
        conta.Sacar(valorASacar);
        decimal novoSaldo = saldoAntesDoSaque - valorASacar;

        // Assert
        Assert.Equal(novoSaldo, conta.Saldo);
    }

    [Fact]
    public void DepositarUmValorPositivoDeveAumentarOSaldo()
    {
        // Arrange
        var conta = new tdd_conta_bancaria.Models.ContaBancaria();
        var saldoAntesDoDeposito = conta.Saldo;

        // Act
        decimal valorADepositar = 50;
        conta.Depositar(valorADepositar);
        decimal novoSaldo = saldoAntesDoDeposito + valorADepositar;

        // Assert
        Assert.Equal(novoSaldo, conta.Saldo);
    }

    [Fact]
    public void DepositarUmValorNegativoNaoDeveAlterarOSaldo()
    {
        // Arrange
        var conta = new tdd_conta_bancaria.Models.ContaBancaria();
        var saldoAntesDoDeposito = conta.Saldo;

        // Act
        decimal valorADepositar = -50;
        conta.Depositar(valorADepositar);

        // Assert
        Assert.Equal(saldoAntesDoDeposito, conta.Saldo);
    }

    [Fact]
    public void DepositarZeroNaoDeveAlterarOSaldo()
    {
        // Arrange
        var conta = new tdd_conta_bancaria.Models.ContaBancaria();
        var saldoAntesDoDeposito = conta.Saldo;

        // Act
        decimal valorADepositar = 0;
        conta.Depositar(valorADepositar);

        // Assert
        Assert.Equal(saldoAntesDoDeposito, conta.Saldo);
    }
}
