using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CekBilPrima
{
    internal class Program
    {
        private const int V = 1;

        static void Main(string[] args)
        {
            //Cek bil prima
            Console.Write("Input angka : ");
            int input = Convert.ToInt32(Console.ReadLine());
            //cek input
            int count = 0;
            int temp = 0;
            for (int i = 1; i < input + V; i++)
            {
                temp = input % i;
                if (temp == 0)
                {
                    count++;
                }
            }
            if (count > 2)
            {
                Console.Write("Bukan bilangan Prima\n");
            }
            else
            {
                Console.Write(input + " adalah bilangan Prima!\n");
            }
        }
    }
}
