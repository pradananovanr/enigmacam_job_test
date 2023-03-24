namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 1, z = 0;

            Console.Write("Masukan jumlah bilangan fibonacci = ");
            int jumlah = Convert.ToInt32(Console.ReadLine());
            Console.Write(x + " " + y + " ");

            for (int i = 2; i < jumlah; i++)
            {
                z = x + y;
                Console.Write(z + " ");
                x = y;
                y = z;
            }

            Console.Read();
        }
    }
}
