using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = new int[10];
                numbers[0]=1;
                numbers[1]=2;
                MessageBox.Show(numbers[10].ToString())
;                int c = int.Parse(textBox1.Text);
                double f = c*(9/5.0)+32;
                label3.Text = f.ToString()+"度F";
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message+"輸入的不可以是標點符號，請輸入整數");
            }catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message+"你宣告的陣列爆掉了拉!");
            } catch (System.Exception ex) {
           
                MessageBox.Show(ex.Message+"你輸入的有問題，但我不知道哪裡錯");
            }

        }
            
        
    }
}