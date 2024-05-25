namespace s26.con;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Name? ");
        var name = Console.ReadLine();
        Console.Write("Mobile? ");
        var m1 = int.Parse(Console.ReadLine());
        Console.Write("2nd Mobile? ");
        var m2 = int.Parse(Console.ReadLine());

        var acct = new Account(name, 0, (m1, m2));
        Account.BankReportDelegate d1 = (msg, o) =>
        {
            (int m, _) = (ValueTuple<int,int>)o;
            using var v = new SetColor(ConsoleColor.DarkCyan);
            Console.WriteLine($"Sending SMS to {m} for {name}: {msg}");
        };
        acct.Reporter += d1;
        // acct.Reporter = d1;

        Account.BankReportDelegate d2 = (msg,o) =>
        {
            (_, int m) = (ValueTuple<int,int>)o;
            using var v = new SetColor(ConsoleColor.DarkCyan);
            Console.WriteLine($"Sending SMS to {m} for {name}: {msg}");
        };

        acct.Reporter += d2;


        while (true)
        {
            var cmd = Console.ReadLine();
            var toks = cmd.Split();
            var amount = double.Parse(toks[1]);
            if (toks[0] == "+")
                acct.Deposit(amount);
            else if (toks[0] == "-")
                acct.Withdraw(amount);
            else
                System.Console.WriteLine($"Unknown Cmd: {cmd}");

            acct.Reporter -= d2;
        }
    }
}
