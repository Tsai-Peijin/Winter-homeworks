using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winter_homework06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int saturday = 0, sunday = 0, days = 365;
            var years = textBox1.Text;

            if (int.TryParse(years, out int y))
            {
                var year = y + 1911;
                var firstDayOfYear = new DateTime(year, 1, 1);
                if (DateTime.IsLeapYear(year))
                    days++;
                for (int i = 1; i <= days; i++)
                {
                    if (firstDayOfYear.DayOfWeek == DayOfWeek.Saturday)
                        saturday++;
                    if (firstDayOfYear.DayOfWeek == DayOfWeek.Sunday)
                        sunday++;
                    firstDayOfYear = firstDayOfYear.AddDays(1);
                }
                MessageBox.Show("民國" + y + "年 星期六有 " + sunday.ToString() + "天\n" +
                                "民國" + y + "年 星期天有 " + sunday.ToString() + "天");

            }
        }
    }
}
