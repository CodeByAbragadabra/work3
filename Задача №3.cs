internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 100; i < 500; i++)
        {
            int num1 = i / 100;
            int num2 = i / 10 % 10;
            int num3 = i % 10;

            if (num1 + num2 + num3 == 15)
            {
                Console.WriteLine(i);
            }
        }
    }
}