namespace tdd_conta_bancaria.Models;

public class ContaBancaria
{
    public decimal Saldo { get; private set; }

    public ContaBancaria()
    {
        Saldo = 0;
    }
}
