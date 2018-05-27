using System;
using System.Linq;

namespace Winter_homework09
{
    class Result
    {
        public bool HasValue { get; set; }
        public decimal Ticket { get; set; }
    }
    class TicketCalculator
    {
        private bool _isReturn;
        private bool _isDiscount;
        public Result GetFare(string start, string end, bool isReturn, bool isDiscount, bool isToSouth)
        {
            _isReturn = isReturn;
            _isDiscount = isDiscount;
            Start ticketFare;  //  從Start類別中建立 ticketFare
            ticketFare = GetBaseTicketFare(start, end, isToSouth);  

            if (ticketFare == null)  // 如果車票=null
            {
                return new Result { HasValue = false };  // HasValue = false (沒有值)
            }
            else
            {
                var fare = Math.Ceiling(GetDiscount(GetReturn(ticketFare.Pirce))); 
                //                       優待票        來回票     單張      價錢
                // 先回傳單趟的票價(ticketFare)，再回傳有無勾選來回票，最後優待票
                return new Result { HasValue = true, Ticket = fare };  // 回傳新的值
            }
        }
        private static Start GetBaseTicketFare(string start, string end, bool isToSouth) // 找票價
        {
            Start ticketFare;
            if (isToSouth) // 南下
            {
                ticketFare = PriceList.GetTicketList().FirstOrDefault((x) => x.StartStation == start && x.EndStation == end);
                // Start.PriceList 中的清單找 "起站" 和 "訖站" 
            }
            else
            {
                ticketFare = PriceList.GetTicketList().FirstOrDefault((x) => x.EndStation == start && x.StartStation == end);
                // Start.PriceList 中的清單找 "訖站" 和 "起站"
            }
            return ticketFare; // 回傳票價字串
        }

        private decimal GetReturn(decimal price)  // 回傳票價
        {
            if (_isReturn) // 來回票
            {
                return price * 2 * 0.9m;
            }
            else
            {
                return price;
            }
        }

        private decimal GetDiscount(decimal price)
        {
            if (_isDiscount)  // 優待票
            {
                return price * 0.9m;
            }
            else
            {
                return price;
            }
        }
    }
}