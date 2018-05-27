using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winter_homework07
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> value = new Dictionary<char, string>();
            value.Add('1', "一");
            value.Add('2', "二");
            value.Add('3', "三");
            value.Add('4', "四");
            value.Add('5', "五");
            value.Add('6', "六");
            value.Add('7', "七");
            value.Add('8', "八");
            value.Add('9', "九");
            value.Add('0', "零");

            Console.Write("請輸入一串數值：");
            string input = Console.ReadLine();
            
            StringBuilder Math= new StringBuilder();//字元字串
            foreach(var m in input)
            {
                Math.Append(value[m]);//將陣列中字元字串附加到執行個體(math)
            }
            input = Math.ToString();
            Console.WriteLine("{0}", input);
            Console.ReadLine();

            /*for (int i = 0; i < input.Length; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.Write("一");
                        break;
                    case 2:
                        Console.Write("二");
                        break;
                    case 3:
                        Console.Write("三");
                        break;
                    case 4:
                        Console.Write("四");
                        break;
                    case 5:
                        Console.Write("五");
                        break;
                    case 6:
                        Console.Write("六");
                        break;
                    case 7:
                        Console.Write("七");
                        break;
                    case 8:
                        Console.Write("八");
                        break;
                    case 9:
                        Console.Write("九");
                        break;
                    default:
                        Console.Write("零");
                        break;
                }
            }*/
        }
    }
}
