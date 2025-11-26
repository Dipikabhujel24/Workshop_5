namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount("ACC123", 500);

            Console.WriteLine("Account Number:" + b.AccoumtNumber);
            Console.WriteLine("Initial Balance:" + b.Balance);

            b.Deposit(200);
            b.Withdraw(200);

            Console.WriteLine("Remaining Balance:" + b.Balance);
        }
    }
}
