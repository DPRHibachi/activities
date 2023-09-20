using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace delete4
{
    public partial class Form1 : Form
    {
        public int var1 = -1;
        public Form1()
        {
            InitializeComponent();
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var1++;
            try
            {
                string search = textBox2.Text;
                string input = textBox1.Text;
         

                if (var1 < input.Length)
                {
                    string letter = ("" + input[var1]);
                    
                    if (search == letter )
                    {                   
                      label1.Text = letter; 
                        timer1.Stop();
                        var1 = -1;

                    }
                }
                else
                {
                   label1.Text = ("Input:" + search + " " + "is not found!");
                    timer1.Stop();
                    var1 = -1;
                    

                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("input numbers / letters!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

