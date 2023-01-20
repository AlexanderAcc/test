using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        int s = 0;
        int m = 0;

        public Form1()
        {
            InitializeComponent();
            this.Icon = SystemIcons.Question;// Изменение иконки приложения
        }

        private void HideE() //Показать картинки 
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label3.Visible = true;
            Off();
        }
        private void UnHide() //Скрыть каритнки
        {
            if(radioButton2.Checked == true)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
            }

            label3.Visible = false;
            On();
        }
        private void Off() // невидимые точки
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
        }
        private void On() // Видимые точки
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
        }

        private void AData() //Физ данные
        {
            HideE();
            label3.Text = Properties.Resources.aboutData;
            checkBox1.Visible = false;
            tabControl1.Visible = false;
        }
        private void Bio() // Биография
        {
            HideE();
            label3.Text = Properties.Resources.bio;
            checkBox1.Visible = false;
            tabControl1.Visible = false;
        }
        private void Docs() //Документы
        {
            tabControl1.Visible = true;
            if(checkBox1.Checked == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
            label3.Visible = false;
            checkBox1.Visible = true;
            tabControl1.Visible = true;

            pictureBox1.Image = Properties.Resources._1;
            pictureBox2.Image = Properties.Resources._2;
        }
        private void Hobby()//Хобби
        {
            HideE();
            label3.Text = Properties.Resources.hobby;
            checkBox1.Visible = false;
            tabControl1.Visible = false;
        }
        private void MultiMedia() // Мультимедиа
        {
            tabControl1.Visible = true;
            HideE();
            UnHide();
            pictureBox1.Image = Properties.Resources._3;
            pictureBox2.Image = Properties.Resources._4;
            checkBox1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sI = comboBox1.SelectedIndex;

            if(sI == 0) // физ данные
            {
                label1.Text = Convert.ToString(comboBox1.Items[sI]);
                AData();
            }
            if (sI == 1) // биография
            {
                label1.Text = Convert.ToString(comboBox1.Items[sI]);
                Bio();
            }
            if (sI == 2) // документы
            {
                label1.Text = Convert.ToString(comboBox1.Items[sI]);
                Docs();
            }
            if (sI == 3) // хобби
            {
                label1.Text = Convert.ToString(comboBox1.Items[sI]);
                Hobby();
            }
            if (sI == 4) // мультимедиа
            {
                label1.Text = Convert.ToString(comboBox1.Items[sI]);
                MultiMedia();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true) //Невидимые картинки
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true) //Видимы картинки
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) // невидимы
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;// видимы
                pictureBox2.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "1") // физ данные
            {
                label1.Text = Convert.ToString(comboBox1.Items[0]);
                AData();
                textBox1.Text = "";
            }
            if (textBox1.Text == "2") // биография
            {
                label1.Text = Convert.ToString(comboBox1.Items[1]);
                Bio();
                textBox1.Text = "";
            }
            if (textBox1.Text == "3") // документы
            {
                label1.Text = Convert.ToString(comboBox1.Items[2]);
                Docs();
                textBox1.Text = "";
            }
            if (textBox1.Text == "4") // хобби
            {
                label1.Text = Convert.ToString(comboBox1.Items[3]);
                Hobby();
                textBox1.Text = "";
            }
            if (textBox1.Text == "5") // мультимедиа
            {
                label1.Text = Convert.ToString(comboBox1.Items[4]);
                MultiMedia();
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e) //Выключение приложения
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e) // таймер
        {
            s++;
            
            if(s == 58)
            {
                m++;
                s = 0;
            }

            label5.Text = m + " min " + s + " sec";
        }
    }
}
