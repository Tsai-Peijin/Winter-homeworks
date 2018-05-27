using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的字串 : "); 
            string[] array = Console.ReadLine().Split(','); 
            Console.WriteLine("反向顯示 : "); 
            for (int i = array.Length - 1; i >= 0; i--) 
            {
                if (i == 0)
                    Console.Write(array[i]);
                else
                    Console.Write(array[i] + ',');
            }
            Console.ReadLine();
        }
    }
}
