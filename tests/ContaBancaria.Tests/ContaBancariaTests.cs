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

        // Assert
        Assert.Equal(saldoAntesDoSaque, conta.Saldo);
    }

    [Fact]
    public void SacarUmValorInferiorAoSaldoDeveReduzirOSaldoCorretamente()
    {
        // Arrange
        var conta = new tdd_conta_bancaria.Models.ContaBancaria();
        var saldoAntesDoSaque = conta.Saldo;

        // Act
        decimal valorASacar = 50;
        decimal novoSaldo = saldoAntesDoSaque - valorASacar;

        // Assert
        Assert.Equal(novoSaldo, conta.Saldo);
    }
}
