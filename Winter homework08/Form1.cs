using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winter_homework08
{
    public partial class Form1 : Form
    {
        private List<Sales_volume> list;
        private List<Sales_Volume> _list;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            CreateList2();
            dataGridView1.DataSource = list;
            dataGridView2.DataSource = _list;

            var person = list.Where((a) => a.Total == list.Max((s) => s.Total));
            foreach (var A in person)
            {
                label3.Text = string.Format("最佳銷售員：" + A.Salesman);
            }
            var thing = _list.Where((x) => x.Sum == _list.Max((c) => c.Sum));
            foreach (var Z in thing)
            {
                label4.Text = string.Format("最佳產品：" + Z.Product);
            }

        }
        private void CreateList()
        {
            list = new List<Sales_volume>();
            list.Add(new Sales_volume() { Salesman = "Bill", Pen = 33, Pencil = 32, Eraser = 56, Ruler = 45, Liwhite = 33 });
            list.Add(new Sales_volume() { Salesman = "John", Pen = 77, Pencil = 33, Eraser = 68, Ruler = 45, Liwhite = 23 });
            list.Add(new Sales_volume() { Salesman = "David", Pen = 43, Pencil = 55, Eraser = 43, Ruler = 67, Liwhite = 65 });
        }
        private void CreateList2()
        {
            _list = new List<Sales_Volume>();
            _list.Add(new Sales_Volume { Product = "原子筆", Price = 12, Totals = 153 });
            _list.Add(new Sales_Volume { Product = "鉛筆", Price = 16, Totals = 128 });
            _list.Add(new Sales_Volume { Product = "橡皮擦", Price = 10, Totals = 167 });
            _list.Add(new Sales_Volume { Product = "直尺", Price = 14, Totals = 157 });
            _list.Add(new Sales_Volume { Product = "立可白", Price = 15, Totals = 121 });
        }

    }
}
