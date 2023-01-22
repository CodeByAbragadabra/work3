internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 1000; i < 9999; i++)
        {
            if (i % 47 == 43 || i % 43 == 37)
            {
                Console.Write(i + ", ");
            }
        }
    }
}