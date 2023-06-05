namespace if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3;
            if (a > b || b > c)
            {
                Console.WriteLine("condition IF is true");

            }
            else if(a < b && b == c)
            {
                Console.WriteLine("condition ELSE-IF is true");

            }

            else
            {
                Console.WriteLine("condition ELSE is true");

            }
        }
    }
}