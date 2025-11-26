namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car { Brand = "Toyota", Speed = 160, Seats = 4 };
            Motorcycle m = new Motorcycle { Brand = "Honda", Speed = 120, HasHelmet = true };

            c.Start();
            c.DisplayInfo();
            c.Stop();

            Console.WriteLine();

            m.Start();
            m.DisplayInfo();
            m.Stop();

            Console.WriteLine("");
        }
    }
}
