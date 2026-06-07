using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        int b = 0;

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

   

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                b = b + 1;
            }

            button1.Visible = false;
            tabControl1.SelectedIndex = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "памяти для хранения данных")
                b = b + 1;
            button2.Visible = false;
            tabControl1.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {

                b = b + 1;
            }

            button3.Visible = false;
            tabControl1.SelectedIndex = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox3.Checked == false && checkBox2.Checked == true)
                b = b + 1;
            button4.Visible = false;
            tabControl1.SelectedIndex = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true) 
                b = b + 1;
            button5 .Visible = false;
            tabControl1.SelectedIndex = 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                b = b + 1;
            button7.Visible = false;
            tabControl1.SelectedIndex = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton14.Checked == true)
                b = b + 1; 
            button8.Visible = false;
            tabControl1.SelectedIndex = 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "результат" || textBox3.Text == "Результат")
                b=b+1;
            button10.Visible = false;
            tabControl1.SelectedIndex = 10;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Среда разработки" || textBox3.Text == "cреда разработки")
                b = b + 1;
            button11.Visible = false;
            tabControl1.SelectedIndex = 11;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(radioButton19.Checked == true)
                b = b + 1;
            button12.Visible = false;
            tabControl1.SelectedIndex = 12;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true && checkBox5.Checked == true)
                b = b + 1;
            button13.Visible = false;
            tabControl1.SelectedIndex = 13;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton23.Checked == true)
                b = b + 1;
            button14.Visible = false;
            tabControl1.SelectedIndex = 14;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "Поиск и исправление ошибок в программе" || textBox3.Text == "поиск и исправление ошибок в программе")
                b = b + 1;
            button15.Visible = false;
            tabControl1.SelectedIndex = 15;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (radioButton26.Checked == true)
                b = b + 1;
            button16.Visible = false;
            tabControl1.SelectedIndex = 16;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "Очередь"|| textBox6.Text == "очередь")
                b = b + 1;
            button17.Visible = false;
            tabControl1.SelectedIndex = 17;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true && checkBox9.Checked == true)
                b = b + 1;
            button18.Visible = false;
            tabControl1.SelectedIndex = 18;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "Оконное" || textBox6.Text == "оконное")
                b = b + 1;
            button20.Visible = false;
            tabControl1.SelectedIndex = 20;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
                b = b + 1;
            button9.Visible = false;
            tabControl1.SelectedIndex = 9;
        }


        private void button21_Click_1(object sender, EventArgs e)
        {
            label22.Text = "Набрано баллов= " + Convert.ToString(b); ;
            if (b >= 18)
            {
                label21.Text = "Оценка 5 (отлично)";
                pictureBox2.Visible = false;
            }
            if (b >= 10 && b < 18) label21.Text = "Оценка 4(хорошо)";
            if (b == 7 || b == 8 || b == 9) label21.Text = "Оценка 3(удовлетворительно)";
            if (b == 6 || b == 5 || b == 4 || b == 3) {
                pictureBox1.Visible = true;
                label21.Text = "Оценка 2(плохо)";
            }
            if (b == 2 || b == 1 || b == 0) { 
                pictureBox1.Visible = true;
                label21.Text = "Оценка 1(все ужасно)";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void пройтиТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            tabControl1.SelectedIndex = 0;
            button2.Visible = true;
            button1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;
            radioButton21.Checked = false;
            radioButton22.Checked = false;
            radioButton23.Checked = false;
            radioButton24.Checked = false;
            radioButton25.Checked = false;
            radioButton26.Checked = false;
            radioButton27.Checked = false;
            radioButton28.Checked = false;
            radioButton29.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = ""; 
            textBox7.Text = "";
            label22.Text = "Набрано баллов= ";
            label21.Text = "";
            b = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true) { b++; }
            button6.Visible = false;
            tabControl1.SelectedIndex = 6;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(radioButton29.Checked == true) 
            { b++; }
            button19.Visible = false;
            tabControl1.SelectedIndex = 19;
        }
    }
}
