namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NepaliTeacher nt = new NepaliTeacher { Name = "Hari" };
            EnglishTeacher et = new EnglishTeacher { Name = "John" };

            nt.Teaching();
            nt.SalaryInfo();

            et.Teaching();
            et.SalaryInfo();
            Console.WriteLine("");
        }
    }
}
