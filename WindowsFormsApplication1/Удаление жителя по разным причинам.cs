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
    public partial class Form2 : Form
    {
        public List<Пароль.life> B = new List<Пароль.life>();
        public List<Пароль.life> A = new List<Пароль.life>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e) //Кнопка "Перенести"
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

        private void button4_Click(object sender, EventArgs e)
        {
            Меню a = new Меню();
            this.Hide();
            a.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e) //кнопка "Список выбывших жителей"
        {

            try
            {
                B.RemoveAt(listBox1.SelectedIndex);
            }
            catch { MessageBox.Show("Выберите запись"); }
            listBox1.Items.Clear();
            foreach (Пароль.life a in B)
                listBox1.Items.Add(a.firstname + "\t\t" + a.name + "\t\t" + a.otchestvo + "\t\t" + a.data.ToShortDateString() + "\t\t" + a.SP + "\t\t" + a.phone + "\t\t" + a.adres + "\t\t" + a.stropolis + "\t\t" + a.inn + "\t\t" + a.rozhd + "\t\t" + a.rab + "\t\t" + a.pol + "\t\t" + a.town + "\t\t");


            var r = new System.IO.StreamWriter("life.txt", false); //новый файл life1
            foreach (Пароль.life a in B)
            {
                r.WriteLine(a.firstname);
                r.WriteLine(a.name);
                r.WriteLine(a.otchestvo);
                r.WriteLine(a.data);
                r.WriteLine(a.SP);
                r.WriteLine(a.phone);
                r.WriteLine(a.adres);
                r.WriteLine(a.stropolis);
                r.WriteLine(a.inn);
                r.WriteLine(a.rozhd);
                r.WriteLine(a.rab);
                r.WriteLine(a.pol);
                r.WriteLine(a.town);
            }
            r.Close();
            A.Add(new Пароль.life()
           {
               firstname = Convert.ToString(textBox1.Text),
               name = Convert.ToString(textBox2.Text),
               otchestvo = Convert.ToString(textBox3.Text),
               data = dateTimePicker1.Value,
               SP = comboBox2.Text,
               phone = Convert.ToString(textBox6.Text),
               adres = Convert.ToString(textBox7.Text),
               stropolis = Convert.ToString(textBox8.Text),
               inn = Convert.ToString(textBox9.Text),
               rozhd = Convert.ToString(textBox4.Text),
               rab = Convert.ToString(textBox10.Text),
               pol = comboBox1.Text,
               town = Convert.ToString(textBox5.Text),
               pric = Convert.ToString(textBox11.Text)
           }
           );

            var d = new System.IO.StreamWriter("life1.txt", true);
            foreach (Пароль.life res in A)
            {
                d.WriteLine(res.firstname);
                d.WriteLine(res.name);
                d.WriteLine(res.otchestvo);
                d.WriteLine(res.data);
                d.WriteLine(res.SP);
                d.WriteLine(res.phone);
                d.WriteLine(res.adres);
                d.WriteLine(res.stropolis);
                d.WriteLine(res.inn);
                d.WriteLine(res.rozhd);
                d.WriteLine(res.rab);
                d.WriteLine(res.pol);
                d.WriteLine(res.town);
                d.WriteLine(res.pric);


            }
            d.Close();
            MessageBox.Show("Успешно сохранено!");
            {

                Form3 a = new Form3();
                this.Hide();
                a.ShowDialog();
            }

        }

    }
}