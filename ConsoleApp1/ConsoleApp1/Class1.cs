﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class TicketFare
    {
        public string StartStation { get; set; }
        public string EndStation { get; set; }
        public decimal Fare { get; set; }
    }

    public class PriceList
    {
        public static List<TicketFare> GetTicketList()
        {
            var result = new List<TicketFare>
            {
                new TicketFare{StartStation = "台北", EndStation = "新竹", Fare = 177},
                new TicketFare{StartStation = "台北", EndStation = "台中", Fare = 375},
                new TicketFare{StartStation = "台北", EndStation = "嘉義", Fare = 598},
                new TicketFare{StartStation = "台北", EndStation = "台南", Fare = 738},
                new TicketFare{StartStation = "台北", EndStation = "高雄", Fare = 842},
                new TicketFare{StartStation = "新竹", EndStation = "台中", Fare = 197},
                new TicketFare{StartStation = "新竹", EndStation = "嘉義", Fare = 421},
                new TicketFare{StartStation = "新竹", EndStation = "台南", Fare = 560},
                new TicketFare{StartStation = "新竹", EndStation = "高雄", Fare = 755},
                new TicketFare{StartStation = "台中", EndStation = "嘉義", Fare = 224},
                new TicketFare{StartStation = "台中", EndStation = "台南", Fare = 363},
                new TicketFare{StartStation = "台中", EndStation = "高雄", Fare = 469},
                new TicketFare{StartStation = "嘉義", EndStation = "台南", Fare = 139},
                new TicketFare{StartStation = "嘉義", EndStation = "高雄", Fare = 245},
                new TicketFare{StartStation = "台南", EndStation = "高雄", Fare = 106},
            };

            return result;
        }
       
    }
    public class Starts : IEqualityComparer<TicketFare>
    {
        public bool Equals(TicketFare x, TicketFare y)
        {
            return x.StartStation == y.StartStation;
        }

        public int GetHashCode(TicketFare obj)
        {
            return obj.StartStation.GetHashCode();
        }
    }

    public class End : IEqualityComparer<TicketFare>
    {
        public bool Equals(TicketFare x, TicketFare y)
        {
            return x.EndStation == y.EndStation;
        }

        public int GetHashCode(TicketFare obj)
        {
            return obj.EndStation.GetHashCode();
        }
    }
}
