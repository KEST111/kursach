using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Подключаем пространство имен для работы с файлами

namespace WindowsFormsApplication1
{
    public partial class Добавление : Form
    {
        public List<Пароль.life> B = new List<Пароль.life>();
        public Добавление()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //кнопка "Главное меню"
        {
            Меню a = new Меню();
            this.Hide();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //кнопка "Сохранение"
        {
            {
               
                B.Add(new Пароль.life()
            {
                firstname = Convert.ToString(textBox1.Text),
                name = Convert.ToString(textBox2.Text),
                otchestvo = Convert.ToString(textBox3.Text),
                data = dateTimePicker1.Value,
                SP = comboBox2.Text,
                phone = Convert.ToString(textBox6.Text),
                 adres = Convert.ToString(textBox7.Text),
                 stropolis=Convert.ToString(textBox8.Text),
                 inn=Convert.ToString(textBox9.Text),
                 rozhd=Convert.ToString(textBox4.Text),
                  rab=Convert.ToString(textBox10.Text),
                  pol=comboBox1.Text,
                  town=Convert.ToString(textBox5.Text)


            }
                    );


            StreamWriter write = new StreamWriter("life.txt");
            foreach (Пароль.life res in B)
            {

                write.WriteLine(res.firstname);
               write.WriteLine(res.name);
                write.WriteLine(res.otchestvo);
                write.WriteLine(res.data);
                write.WriteLine(res.SP);
                 write.WriteLine(res.phone);
                write.WriteLine(res.adres);
                write.WriteLine(res.stropolis);
                write.WriteLine(res.inn);
                write.WriteLine(res.rozhd);
                write.WriteLine(res.rab);
                write.WriteLine(res.pol);
                write.WriteLine(res.town);

            }

            MessageBox.Show("Сохранение выполнено");
            write.Close();
          
        }
            }

        private void Form3_Load(object sender, EventArgs e)
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

            } n.Close();
        }

        private void button3_Click(object sender, EventArgs e) //кнопка "Очистить поля"
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox5.Clear();
            }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
        }
}

        
    

