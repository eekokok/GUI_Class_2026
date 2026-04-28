using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI_Class_2026
{
   public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new FormCalculator().Show(); 
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int sum = a+ b;
            label3.Text = sum.ToString();
        }
        int count = 0;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            count++;
            lab_Count.Text = count.ToString();
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            count--;
            lab_Count.Text = count.ToString();
        }
    }
}
