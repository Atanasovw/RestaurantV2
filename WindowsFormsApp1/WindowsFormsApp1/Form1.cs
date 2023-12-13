using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string table = "";
            string payment = "";
            
            if (radioButton1.Checked)
            {
                table = radioButton1.Text;
            }
            else { table = radioButton2.Text; }

            if (radioButton3.Checked)
            {
                payment = radioButton3.Text;
            }
            else { 
            payment = radioButton4.Text;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Трябва да изберете брой души за резервация");
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Вие избрахте маса за: " + table + " с/ъс " + textBox1.Text + " души за резервация и платежният ви метод е: " + payment);
                Form11 f1 = new Form11(radioButton3.Checked);
                f1.Show();
                Form1 form = new Form1();
                form.Hide();
            }
             
            
        }
        
    }
}
