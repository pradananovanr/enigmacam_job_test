namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan jumlah baris segitiga = ");
            int jumlah = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= jumlah; i++)
            {
                for (int j = 1; j <= jumlah; j++)
                {
                    if (j >= jumlah - (i - 1) && j <= jumlah + (i - 1))
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
