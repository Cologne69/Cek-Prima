using System;

namespace Cek_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka: ");
            int input = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 2; i <= input/2; i++)
            {
                if (input % i == 0)
                {
                    Console.Write("Angka bukan prima");
                    counter = 1;
                    break;
                }
            }
            if (counter == 0)
                Console.Write("Angka prima");
        }
    }
}
