using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
