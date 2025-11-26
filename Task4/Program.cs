namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Bike b = new Bike();

            c.Display();
            c.StartEngine();
            c.StopEngine();

            Console.WriteLine("");

            b.Display();
            b.StartEngine();
            b.StopEngine();

            Console.WriteLine("");
        }
    }
}
