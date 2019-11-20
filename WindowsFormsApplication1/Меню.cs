using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Название проекта: "+"БД жителей города"+
                "\n Дата начала проекта: 09.09.2014"+
                "\n Дата сдачи проекта: --- "+
                "\n Проект создал: Филаткин Кирилл а.к.а KeST"+
                "\n Все права защищены © 2014"); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Добавление a = new Добавление();
            this.Hide();
            a.ShowDialog();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            Поиск a = new Поиск();
            this.Hide();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Вывод a = new Вывод();
            this.Hide();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Редактирование a = new Редактирование();
            this.Hide();
            a.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           Form2 a = new Form2();
            this.Hide();
            a.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            this.Hide();
            a.ShowDialog();
        }
    }
}
