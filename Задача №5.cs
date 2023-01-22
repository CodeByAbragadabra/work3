internal class Program
{
    private static void Main(string[] args)
    {
        int money = 1000;
        int month = 0;
        do
        {
            money = (money + 2) / 100 + money;
            month++;
        } while (money < 1200);

        Console.WriteLine("Через {0} месяцев будет > 1200 деняг", month);
    }
}