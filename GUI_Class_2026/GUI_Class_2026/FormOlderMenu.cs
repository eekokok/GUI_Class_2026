using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Class_2026
{
    public partial class FormOlderMenu : Form
    {
        public FormOlderMenu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        foreach (Control c in panel1.Controls)
            {
                if(c is CheckBox)
                {
                        CheckBox temp = (CheckBox)c;
                        if(temp.Checked)
                        {
                        MessageBox.Show(temp.Text);
                          
                        }
                }

            }

            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked)
                    {
                        MessageBox.Show(temp.Text);

                    }
                }

            }

            foreach (Control c in panel3.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked)
                    {
                        MessageBox.Show(temp.Text);

                    }
                }

            }
            foreach (Control c in panel4.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked)
                    {
                        MessageBox.Show(temp.Text);

                    }
                }

            }
        }
    }
}
