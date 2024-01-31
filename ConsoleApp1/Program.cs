namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // accept two int numbers and find the maximum then display
            int fno;
            int sno;
            int max;
            Console.Write("Enter First Number: ");
            fno = int.Parse(Console.ReadLine());
            Console.Write("Enter Second number: ");
            sno = int.Parse(Console.ReadLine());

            if (fno > sno)
                max = fno;
            else
                max = sno;
            Console.WriteLine($"The max of {fno} and {sno} is {max}");

        }
    }
}
