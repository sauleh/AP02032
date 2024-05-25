public class SetColor: IDisposable
{
    private ConsoleColor OldColor;
    public SetColor(ConsoleColor c)
    {
        OldColor = Console.ForegroundColor;
        Console.ForegroundColor = c;
    }

    public void Dispose()
    {
        Console.ForegroundColor = OldColor;
    }
}

public class Account
{
    public delegate void BankReportDelegate(string msg, object obj);
    public event BankReportDelegate Reporter;
    public string Holder {get;}
    private object Data;
    public double Balance { get; private set; }
    public Account(string holder, double balance, object data)
    {
        this.Holder = holder;
        this.Balance = balance;
        this.Data = data;
    }

    public bool Withdraw(double amount)
    {
        string msg = string.Empty;
        if (amount <= Balance)
        {
            Balance -= amount;
            using var v1 = new SetColor(ConsoleColor.Red);
            msg = $"-{amount}, {Balance}";
            Reporter?.Invoke(msg, this.Data);
            Console.WriteLine(msg);
            return true;
        }
        using var v2 = new SetColor(ConsoleColor.Yellow);
        msg = $"-{amount}, {Balance} Unsuccessful";
        Reporter?.Invoke(msg, this.Data);
        Console.WriteLine(msg);
        return false;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        using var v1 = new SetColor(ConsoleColor.Green);
        var msg = $"+{amount}, {Balance}";
        Reporter?.Invoke(msg, this.Data);
        Console.WriteLine(msg);        
    }
}