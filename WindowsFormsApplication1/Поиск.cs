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

namespace WindowsFormsApplication1
{
    public partial class Поиск : Form
    {
        public List<Пароль.life> B = new List<Пароль.life>();
        public Поиск()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //"Главное меню"
        {
            Меню a = new Меню();
            this.Hide();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) //кнопка "Поиск"
        {
            int i = 0;
            listBox2.Items.Clear();
            foreach (Пароль.life a in B)

                if (Convert.ToString(textBox1.Text) == a.firstname)
                {

                    listBox2.Items.Add(a.firstname + "\t\t" + a.name + "\t\t" + a.otchestvo + "\t\t" + a.data.ToShortDateString() + "\t\t" + a.SP + "\t\t" + a.phone + "\t\t" + a.adres + "\t\t" + a.stropolis + "\t\t" + a.inn + "\t\t" + a.rozhd + "\t\t" + a.rab + "\t\t" + a.pol + "\t\t" + a.town + "\t\t");
                    i++;
                }
            if (i == 0)
            {
                MessageBox.Show("Ничего не найдено!");
            }
        }

        private void button1_Click(object sender, EventArgs e) // кнопка "Вывод"
        {
            {

                StreamReader n = new StreamReader("life.txt");
                while (!n.EndOfStream)
                {
                    B.Add(new Пароль.life()
                    {
                        firstname = n.ReadLine(),
                        name = n.ReadLine(),
                        otchestvo = n.ReadLine(),
                        data = Convert.ToDateTime(n.ReadLine()),
                        SP = n.ReadLine(),
                        phone = n.ReadLine(),
                        adres = n.ReadLine(),
                        stropolis = n.ReadLine(),
                        inn = n.ReadLine(),
                        rozhd = n.ReadLine(),
                        rab = n.ReadLine(),
                        pol = n.ReadLine(),
                        town = n.ReadLine()



                    });
                }
                n.Close();

                foreach (Пароль.life a in B)
                    listBox1.Items.Add(a.firstname + "\t\t" + a.name + "\t\t" + a.otchestvo + "\t\t" + a.data.ToShortDateString() + "\t\t" + a.SP + "\t\t" + a.phone + "\t\t" + a.adres + "\t\t" + a.stropolis + "\t\t" + a.inn + "\t\t" + a.rozhd + "\t\t" + a.rab + "\t\t" + a.pol + "\t\t" + a.town + "\t\t");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            listBox2.Items.Clear();
            foreach (Пароль.life a in B)

                if (Convert.ToString(textBox2.Text) == a.pol)
                {

                    listBox2.Items.Add(a.firstname + "\t\t" + a.name + "\t\t" + a.otchestvo + "\t\t" + a.data.ToShortDateString() + "\t\t" + a.SP + "\t\t" + a.phone + "\t\t" + a.adres + "\t\t" + a.stropolis + "\t\t" + a.inn + "\t\t" + a.rozhd + "\t\t" + a.rab + "\t\t" + a.pol + "\t\t" + a.town + "\t\t");
                    i++;
                }
            if (i == 0)
            {
                MessageBox.Show("Ничего не найдено!");
            }
        }
    }
}