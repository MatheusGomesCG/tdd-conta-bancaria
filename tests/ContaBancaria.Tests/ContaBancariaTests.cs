namespace ContaBancaria.Test;

public class ContaBancariaTests
{
    [Fact]
    public void NovaContaDeveComecarComSaldoInicialZero()
    {
        // Arrange
        var conta = new ContaBancaria();

        // Act
        var saldoInicial = conta.Saldo;

        // Assert
        Assert.Equal(0, saldoInicial);
    }
}
