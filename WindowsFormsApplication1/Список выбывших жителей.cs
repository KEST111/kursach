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
    public partial class Form3 : Form
    {
        public List<Пароль.life> B = new List<Пароль.life>();
        public List<Пароль.life> A = new List<Пароль.life>();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader n = new StreamReader("life1.txt");
            while (!n.EndOfStream)
            {
                A.Add(new Пароль.life()
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
                    town = n.ReadLine(),
                    pric=n.ReadLine()
                });
            }
            n.Close();

            foreach (Пароль.life a  in A)
                listBox1.Items.Add(a.firstname + "\t\t" + a.name + "\t\t" + a.otchestvo + "\t\t" + a.data.ToShortDateString() + "\t\t" + a.SP + "\t\t" + a.phone + "\t\t" + a.adres + "\t\t" + a.stropolis + "\t\t" + a.inn + "\t\t" + a.rozhd + "\t\t" + a.rab + "\t\t" + a.pol + "\t\t" + a.town + "\t\t" + a.pric + "\t\t");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Меню a = new Меню();
            this.Hide();
            a.ShowDialog();
        }
    }
}
