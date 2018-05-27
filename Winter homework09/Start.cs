using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winter_homework09
{
    class Start
    {
        public string StartStation { get; set; }
        public string EndStation  { get; set; }
        public decimal Pirce { get; set; }
    }
    class PriceList
    {
        public static List<Start> GetTicketList()
        {
            var result = new List<Start>
            {
                new Start{StartStation = "台北", EndStation = "新竹", Pirce = 177},
                new Start{StartStation = "台北", EndStation = "台中", Pirce = 375},
                new Start{StartStation = "台北", EndStation = "嘉義", Pirce = 598},
                new Start{StartStation = "台北", EndStation = "台南", Pirce = 738},
                new Start{StartStation = "台北", EndStation = "高雄", Pirce = 842},
                new Start{StartStation = "新竹", EndStation = "台中", Pirce = 197},
                new Start{StartStation = "新竹", EndStation = "嘉義", Pirce = 421},
                new Start{StartStation = "新竹", EndStation = "台南", Pirce = 560},
                new Start{StartStation = "新竹", EndStation = "高雄", Pirce = 755},
                new Start{StartStation = "台中", EndStation = "嘉義", Pirce = 224},
                new Start{StartStation = "台中", EndStation = "台南", Pirce = 363},
                new Start{StartStation = "台中", EndStation = "高雄", Pirce = 469},
                new Start{StartStation = "嘉義", EndStation = "台南", Pirce = 139},
                new Start{StartStation = "嘉義", EndStation = "高雄", Pirce = 245},
                new Start{StartStation = "台南", EndStation = "高雄", Pirce = 106},
            };

            return result;
        }
    }


}
