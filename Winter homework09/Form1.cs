using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winter_homework09
{
    public partial class Form1 : Form
    {
        private List<Start> Data { get; set; }

        public Form1()
        {
            InitializeComponent();
            Data = PriceList.GetTicketList();
            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            comboBox1.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            radioButton1.Checked = true;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) // 當選取"南下" 
            {
                Setcombobox1();  // 建立下拉選單
            }
            else
            {
                Setcombobox2(); // 選取"北上"
            }
        }

        private void Setcombobox1() // "南下"  從Start裡分群 "起站"當Key值
        {
            comboBox1.DataSource = Data.GroupBy((x) => x.StartStation).Select((x) => x.Key).ToList();
        }
        private void Setcombobox2() // "北上" 從Start裡分群 "訖站"當Key值
        {
            comboBox1.DataSource = Data.GroupBy((x) => x.EndStation).Select((x) => x.Key).ToList();
        }

        
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)  // "南下" 被選擇
            {
                SetCombobox3();
            }
            else
            {
                SetCombobox4(); // "北上"
            }
        }
        private string Getstartstation() // "起站"被選擇的 item
        {
            return comboBox1.SelectedItem.ToString();
        }
        private void SetCombobox3()  // "起站"被選擇的 item 分群至 "訖站"
        {
            string start = Getstartstation();
            comboBox2.DataSource = Data.Where((x) => x.StartStation == start).Select((x) => x.EndStation).ToList();
        }
        private void SetCombobox4() // "訖站"被選擇的 item 分群至 "起站"
        {
            string start = Getstartstation();
            comboBox2.DataSource = Data.Where((x) => x.EndStation == start).Select((x) => x.StartStation).ToList();
        }
       
        private void Button1_Click(object sender, EventArgs e)
        {
            var calculator = new TicketCalculator();
            string start = comboBox1.SelectedItem.ToString();  // combobox1 被選擇的站名
            string end = comboBox2.SelectedItem.ToString();  // combobox2 被選擇的站名
            bool isToSouth = false;  // 北上
            if (radioButton1.Checked)  // 南下
            {
                isToSouth = true;
            }
            var result = calculator.GetFare(start, end, checkBox1.Checked, checkBox2.Checked, isToSouth); // 從 TicketCalculator()中找尋票價
            if (result.HasValue) // true 
            {
                label1.Text = result.Ticket.ToString(); // 印出票價
            }
            else
            {
                label1.Text = "查無此起訖站";
            }
        }

    }
}
