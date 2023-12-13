using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form11 : Form
    {
       
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            groupBox1.Parent = groupBox2.Parent = groupBox3.Parent = groupBox6.Parent = groupBox5.Parent=this;
        }
        public Form11(bool value)
        {
            InitializeComponent();

            
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox15.Text = "0";
            textBox14.Text = "0";
            textBox13.Text = "0";
            textBox18.Text = "0";
            textBox17.Text = "0";
            textBox16.Text = "0";
            textBox10.Text=value.ToString();
        }
        


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox6.Hide();
            groupBox5.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            
            Form1 form = new Form1();
            form.Hide();//скриване на първата форма

          

            
            List<string> list = new List<string>();//създаване на лист за изписване на поръчани ястия
            
            double osn1 = int.Parse(textBox1.Text) * 7.40;//променливи за смятане на сума за продуктите
            double osn2 = int.Parse(textBox2.Text) * 8.60;
            double osn3 = int.Parse(textBox3.Text) * 9.70;
            double des1 = int.Parse(textBox4.Text) * 4.90;
            double des2 = int.Parse(textBox5.Text) * 5.90;
            double des3 = int.Parse(textBox6.Text) * 3.80;
           
            double alc1 = int.Parse(textBox7.Text) * 3.50;
            double alc2 = int.Parse(textBox8.Text) * 4.00;
            double alc3 = int.Parse(textBox9.Text) * 2.50;
            double balc1 = int.Parse(textBox15.Text) * 2.50;
            double balc2 = int.Parse(textBox14.Text) * 2.50;
            double balc3 = int.Parse(textBox13.Text) * 2.50;
            double top1 = int.Parse(textBox18.Text) * 1.50;
            double top2 = int.Parse(textBox17.Text) * 1.50;
            double top3 = int.Parse(textBox16.Text) * 2.50;
            
            double pay = osn1 + osn2 + osn3 + des1 +des2 + des3 + alc1 +alc2+alc3+balc1+balc2+balc3+top1+top2+top3;//пресмятане на обща сума на всички продукти
            if (textBox10.Text == "False")//проверка, ако е избран начин за плащане с карта да се добави 0.05
            {
                pay += 0.05;
            }
            if (int.Parse(textBox1.Text)>0)//проверка за брой поръчани и добавяне към лист
            {
                list.Add(textBox1.Text + "x Печени картофи с бекон и сирене");
                
            }
            if (int.Parse(textBox2.Text) > 0)
            {
                list.Add(textBox2.Text + "x Картофи на пещ с пушена сьомга");
            }
            if (int.Parse(textBox3.Text) > 0)
            {
                list.Add(textBox3.Text + "x Броколи Рокфор ");
            }
            if (int.Parse(textBox4.Text) > 0)
            {
                list.Add(textBox4.Text + "x Палачинка с шоколад");
            }
            if (int.Parse(textBox5.Text) > 0)
            {
                list.Add(textBox5.Text + "x Десерт троен шоколад");
            }
            if (int.Parse(textBox6.Text) > 0)
            {
                list.Add(textBox6.Text + "x Летен десерт с плодове");
            }
            if (int.Parse(textBox7.Text) > 0)
            {
                list.Add(textBox7.Text + "x Бира Хайнекен");
            }
            if (int.Parse(textBox8.Text) > 0)
            {
                list.Add(textBox8.Text + "x Домашна ракия");
            }
            if (int.Parse(textBox9.Text) > 0)
            {
                list.Add(textBox9.Text + "x Уиски Джеймисън");
            }
            if (int.Parse(textBox15.Text) > 0)
            {
                list.Add(textBox15.Text + "x Чай");
            }
            if (int.Parse(textBox14.Text) > 0)
            {
                list.Add(textBox14.Text + "x Кафе");
            }
            if (int.Parse(textBox13.Text) > 0)
            {
                list.Add(textBox13.Text + "x Фрапе");
            }
            if (int.Parse(textBox18.Text) > 0)
            {
                list.Add(textBox18.Text + "x Кока-кола");
            }
            if (int.Parse(textBox17.Text) > 0)
            {
                list.Add(textBox17.Text + "x Фанта портокал");
            }
            if (int.Parse(textBox16.Text) > 0)
            {
                list.Add(textBox16.Text + "x Швепс сода");
            }
            list.Sort();//сортиране на листа
            string s = String.Join(", ", list);//свързване на листа
            MessageBox.Show("Вие поръчахте: "+s+ ". На стойност: " +pay + "лева");//изкарване на съобщение с брой поръчани продукта и обща стойност
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Show();
            groupBox3.Hide();
            groupBox6.Hide();
            groupBox5.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Show();
            groupBox6.Hide();
            groupBox5.Hide();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox6.Hide();
            groupBox5.Show();
        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox6.Show();
            groupBox5.Hide();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
