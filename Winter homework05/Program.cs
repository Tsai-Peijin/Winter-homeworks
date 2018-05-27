using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winter_homework05
{
    class Program
    {
        public class IsLeapYear
        {
            private static int year;

            static void Main(string[] args)
            {

                Console.Write("請輸入一個中華民國年份: ");
                string intput = Console.ReadLine();
                year = int.Parse(intput);
                var years = year + 1911;

                if (DateTime.IsLeapYear(years))
                {
                    Console.WriteLine("民國 " + year + " 年是閏年");
                }
                else
                    Console.WriteLine("民國 " + year + " 年不是閏年");

                /*var y = a + 1911;
                if (y % 4 == 0)
                {
                    Console.WriteLine("民國 " + a + " 年是閏年");
                }
                else
                    Console.WriteLine("民國 " + a + " 年不是閏年");
                    */
                Console.ReadLine();
            }
        }
    }
}
