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
    public partial class Редактирование : Form
    {
        public List<Пароль.life> B = new List<Пароль.life>();
        public Редактирование()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //вывод
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



        private void button2_Click(object sender, EventArgs e) // изменение записи
        {

            B[listBox1.SelectedIndex].firstname = Convert.ToString(textBox1.Text);
            B[listBox1.SelectedIndex].name = Convert.ToString(textBox2.Text);
            B[listBox1.SelectedIndex].otchestvo = Convert.ToString(textBox3.Text);
            B[listBox1.SelectedIndex].data = dateTimePicker1.Value;
            B[listBox1.SelectedIndex].phone = Convert.ToString(textBox6.Text);
            B[listBox1.SelectedIndex].adres = Convert.ToString(textBox7.Text);
            B[listBox1.SelectedIndex].stropolis = Convert.ToString(textBox8.Text);
            B[listBox1.SelectedIndex].inn = Convert.ToString(textBox9.Text);
            B[listBox1.SelectedIndex].rozhd = Convert.ToString(textBox4.Text);
            B[listBox1.SelectedIndex].rab = Convert.ToString(textBox10.Text);
            B[listBox1.SelectedIndex].town = Convert.ToString(textBox5.Text);
            MessageBox.Show("Запись изменена успешно!");

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

        private void button3_Click(object sender, EventArgs e)
        {
            Редактирование a = new Редактирование();
            this.Hide();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Меню a = new Меню();
            this.Hide();
            a.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e) // перенести в текстовые окна
        {
          
                if (textBox1.Text == "") textBox1.Text = B[listBox1.SelectedIndex].firstname;
                if (textBox2.Text == "") textBox2.Text = B[listBox1.SelectedIndex].name;
                if (textBox3.Text == "") textBox3.Text = B[listBox1.SelectedIndex].otchestvo;
                if (comboBox2.Text == "") comboBox2.Text = B[listBox1.SelectedIndex].SP;
                if (textBox6.Text == "") textBox6.Text = B[listBox1.SelectedIndex].phone;
                if (textBox7.Text == "") textBox7.Text = B[listBox1.SelectedIndex].adres;
                if (textBox8.Text == "") textBox8.Text = B[listBox1.SelectedIndex].stropolis;
                if (textBox9.Text == "") textBox9.Text = B[listBox1.SelectedIndex].inn;
                if (textBox4.Text == "") textBox4.Text = B[listBox1.SelectedIndex].rozhd;
                if (textBox10.Text == "") textBox10.Text = B[listBox1.SelectedIndex].rab;
                if (comboBox1.Text == "") comboBox1.Text = B[listBox1.SelectedIndex].pol;
                if (textBox5.Text == "") textBox5.Text = B[listBox1.SelectedIndex].town;

            }
        }
    }
