using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = PriceList.GetTicketList();
            var result = list.Distinct(new End());
            foreach(var item in result)
            {
                Console.WriteLine($"{item.StartStation} -- {item.EndStation}");
            }
            Console.ReadLine();
        }
       
    }
}
