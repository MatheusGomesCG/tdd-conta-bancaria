namespace tdd_conta_bancaria.Models;

public class ContaBancaria
{
    public decimal Saldo { get; private set; }

    public ContaBancaria()
    {
        Saldo = 0;
    }

    public void Depositar(decimal valor)
    {
        if (valor > 0)
            Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor <= Saldo)
            Saldo -= valor;
    }
}
