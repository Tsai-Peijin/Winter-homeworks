using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winter_homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("請輸入一個數字: ");
            string intput = Console.ReadLine();
            i = int.Parse(intput);
            
            if (i % 2 == 0) // 取得餘數
            {
                Console.WriteLine(i + " 是偶數");
            }
            else
            {
                Console.WriteLine(i + " 是奇數");
            }
            Console.ReadLine();
        }
    }
}
