internal class Program
{
    private static void Main(string[] args)
    {
        int time = 0;
        int amoeba = 1;

        while (time < 24)
        {
            if (time % 3 == 0)
            {
                Console.WriteLine("Количество амеб: {0}", amoeba = amoeba * 2);
            }

            time++;
        }
    }
}