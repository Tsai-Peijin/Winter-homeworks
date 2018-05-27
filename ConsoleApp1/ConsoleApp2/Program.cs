using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program // Zodiac
    {


        static void Main(string[] args)
        {
            List<string> list = new List<string> { "牛", "龍", "狗", "兔", "雞" };
            foreach (var item in list.OrderBy((x) => x, new ZComprae()))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public class ZComprae : IComparer<string>
        {
            // 基準不便，所以設 static，才不會執行一次就 new 一次
            private static List<string> zodiac = new List<string> { "鼠", "牛", "虎", "兔", "龍", "蛇", "馬", "羊", "猴", "雞", "狗", "豬" };
            public int Compare(string x, string y)
            {
                return zodiac.IndexOf(x) - zodiac.IndexOf(y);

                // if (zodiac.IndexOf(x) > zodiac.IndexOf(y))
                // {
                //     return 1;
                // }
                // else if (zodiac.IndexOf(x) == zodiac.IndexOf(y))
                // {
                //     return 0;
                // }
                // else { return -1; }
            }
        }

    }
}
