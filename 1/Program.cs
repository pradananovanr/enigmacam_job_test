﻿namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(j);
                    if (j == 5)
                    {
                        Console.WriteLine(" ");
                        for (int k = 1; k <= 1; k++)
                        {
                            for (int l = 5; l >= 1; l--)
                            {
                                Console.Write(l);
                                if (l == 1)
                                {
                                    Console.WriteLine(" ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
