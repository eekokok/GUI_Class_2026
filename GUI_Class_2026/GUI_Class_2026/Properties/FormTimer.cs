using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Class_2026.Properties
{
    public partial class FormTimer : Form
    {
        public FormTimer()
        {
            InitializeComponent();
        }

        private void labcounter_Click(object sender, EventArgs e)
        {
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int counter = Int32.Parse(labcounter.Text.Replace("秒", ""));
            counter+=1;
            labcounter.Text = counter.ToString()+"秒";
        }

        private void FormTimer_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Int32.Parse(label1.Text.Replace("秒", ""));
            timer += 1;
            label1.Text = timer.ToString() + "秒";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "0秒";
            timer2.Enabled = false;
        }
    }
}
