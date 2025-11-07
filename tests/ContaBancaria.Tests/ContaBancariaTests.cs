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
}
