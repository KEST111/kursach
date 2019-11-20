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
    public partial class Вывод : Form
    {
        public List<Пароль.life> B = new List<Пароль.life>();
        public Вывод()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Кнопка "Вывод"
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
                listBox1.Items.Add(a.firstname + "\t\t" + a.name + "\t\t" + a.otchestvo + "\t\t" + a.data.ToShortDateString() + "\t\t" + a.SP + "\t\t" + a.phone + "\t\t" + a.adres + "\t\t" + a.stropolis + "\t\t" + a.inn + "\t\t" + a.rozhd + "\t\t" + a.rab + "\t\t" + a.pol + "\t\t"+a.town+ "\t\t");
                
        }

        private void button2_Click(object sender, EventArgs e) //"Главное меню"
        {
            Меню a = new Меню();
            this.Hide();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) //Сортировка
        {
            listBox1.Sorted = true;
        }

        private void button4_Click(object sender, EventArgs e) //Удаление
        {
            try
            {
                B.RemoveAt(listBox1.SelectedIndex);
            }
            catch { MessageBox.Show("Выберите запись для удаления"); }
            listBox1.Items.Clear();
            foreach (Пароль.life a in B)
                listBox1.Items.Add(a.firstname + "\t\t" + a.name + "\t\t" + a.otchestvo + "\t\t" + a.data.ToShortDateString() + "\t\t" + a.SP + "\t\t" + a.phone + "\t\t" + a.adres + "\t\t" + a.stropolis + "\t\t" + a.inn + "\t\t" + a.rozhd + "\t\t" + a.rab + "\t\t" + a.pol + "\t\t" + a.town + "\t\t");
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
            write.Close();
        }

        private void button5_Click(object sender, EventArgs e) //Подсчет кол-ва
        {
            int kol = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                kol++;
            }
            textBox1.Text = Convert.ToString(kol);
        }   
    }
}
