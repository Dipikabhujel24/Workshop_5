namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();

            p.Print("Hello");
            p.Print(100);
            p.Print("Repeat", 3);
            Console.WriteLine("");

            NepaliTeacher nt = new NepaliTeacher { Name = "Hari" };
            EnglishTeacher et = new EnglishTeacher { Name = "John" };

            nt.Teaching();
            nt.SalaryInfo();

            et.Teaching();
            et.SalaryInfo();
        }
    }
}
