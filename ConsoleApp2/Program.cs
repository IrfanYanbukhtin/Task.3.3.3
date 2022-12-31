namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            int real = (int)n;
            decimal fractional = n - real;
            decimal x = (real / 1000M);
            decimal reverse = x + fractional * 1000;
            Console.WriteLine($"{reverse}");
        }
    }
}