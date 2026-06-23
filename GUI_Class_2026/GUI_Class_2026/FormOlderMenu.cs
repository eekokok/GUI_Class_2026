    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.IO;
    using System.Security.Cryptography;

    namespace GUI_Class_2026
    {
        public partial class FormOlderMenu : Form
        {
            public FormOlderMenu()
            {
                InitializeComponent();
                if (!File.Exists("OrderData.csv")) ;
                File.WriteAllText("OrderData.csv", "時間,主食,配菜,飲品,甜點\n", Encoding.UTF8);

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


                DateTime currenDateTime = DateTime.Now;
                string formattedDateTime = currenDateTime.ToString("yyyy/MM/dd HH:mm:ss");
                string food = "", sideFood = "", drink = "", dessert = "";
        
            
                foreach (Control c in panel1.Controls)//主食
                {
                    if(c is CheckBox)
                    {
                            CheckBox temp = (CheckBox)c;
                            if(temp.Checked)
                            {
                                //MessageBox.Show(temp.Text);
                                food+=" "+temp.Text;
                          
                            }
                    }

                }

                foreach (Control c in panel2.Controls)//配菜區
                {
                    if (c is CheckBox)
                    {
                        CheckBox temp = (CheckBox)c;
                        if (temp.Checked)
                        {
                            //MessageBox.Show(temp.Text);
                            sideFood+=" "+temp.Text;

                        }
                    }

                }

                foreach (Control c in panel3.Controls)//點心區
                {
                    if (c is CheckBox)
                    {
                        CheckBox temp = (CheckBox)c;
                        if (temp.Checked)
                        {
                            //MessageBox.Show(temp.Text);
                            dessert+=" "+temp.Text; ;

                        }
                    }

                }
                foreach (Control c in panel4.Controls)//飲料區
                {
                    if (c is CheckBox)
                    {
                        CheckBox temp = (CheckBox)c;
                        if (temp.Checked)
                        {
                            //MessageBox.Show(temp.Text);
                            drink+=" "+temp.Text; ;


                        }
                    }
                }
                File.AppendAllText("OrderData.csv", formattedDateTime+","+food+","+sideFood+","+drink+","+dessert+"\n");
                MessageBox.Show("點餐完成!製作中請稍後!");
            }
        }
    }
