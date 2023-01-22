internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите целое число больше 10: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 10; i < number; i++)
        {
            Console.WriteLine(Math.Pow(i, 2));
        }
    }
}