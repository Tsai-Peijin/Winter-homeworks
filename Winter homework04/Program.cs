using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winter_homework04
{
    class Program
    {
        private static object Integer;

        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的字串 : ");
            string[] a = Console.ReadLine().Split(',');
            var array = from i in a
                        group i by int.Parse(i) % 2 == 0;
            foreach (var z in array)
            {
                if (z.Key)
                {
                    Console.Write("偶數：");
                }
                else
                {
                    Console.Write("奇數：");
                }
                foreach (var x in z)
                {
                    Console.Write(x + ",");
                }
                Console.ReadLine();
            }
        }
    }
}
