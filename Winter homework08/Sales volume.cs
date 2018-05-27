using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winter_homework08
{
    class Sales_volume
    {
        public string Salesman { get; set; }
        public int Pen { get; set; }
        public int Pencil { get; set; }
        public int Eraser { get; set; }
        public int Ruler { get; set; }
        public int Liwhite { get; set; }
        public int Total
        {
            get { return (Pen * 12) + (Pencil * 16) + (Eraser * 10) + (Ruler * 14) + (Liwhite * 15); }
        }
    }
}
