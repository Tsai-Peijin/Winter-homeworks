using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winter_homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("請輸入一個數字: ");
            string intput = Console.ReadLine();
            a = int.Parse(intput);

            int q = a;

            for (int i = 1; i <= q; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(a);
                }
                a = a - 1;
                Console.WriteLine(); 
            }
            Console.ReadLine();
        }
    }
}
