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
    public partial class Пароль : Form
    {
        public Пароль()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = "kest"; //пароль
            string pass = "123";
            int t = 0;
            if (t != 3)
            {
                if (log == textBox1.Text && pass == textBox2.Text)
                {
                    Меню f = new Меню();
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Не верный логин или пароль! Повторите попытку.");

                }
            }
        }

        public class life : IEquatable<life> //Класс для заполнения форм
        {
            public string firstname { get; set; } //Управляет доступом к полю обьекта.
            public string name { get; set; }
            public string otchestvo { get; set; }
            public DateTime data { get; set; }
            public string SP { get; set; }
            public string phone { get; set; }
            public string adres { get; set; }
            public string stropolis { get; set; }
            public string inn { get; set; }
            public string rozhd { get; set; }
            public string rab { get; set; }
            public string pol { get; set; }
            public string pric { get; set; }
            public string town { get; set; }

            public override string ToString()
            {
                return "";
            }
            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                life objAsPart = obj as life;
                if (objAsPart == null) return false;
                else return Equals(objAsPart);
            }
            public override int GetHashCode()
            {
                return 0;
            }
            public bool Equals(life other)
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.ShowDialog();
        }
    }
}