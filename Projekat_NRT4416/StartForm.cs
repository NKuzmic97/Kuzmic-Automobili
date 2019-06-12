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

namespace Projekat_NRT4416
{
    public partial class StartForm : Form
    {
        string username;
        string password;
        int brojac;
        static Korisnik k;

        public StartForm()
        {
            InitializeComponent();
        }
        private bool UserExists()
        {
            string ln;
            StreamReader f = new StreamReader("users.txt");
            while((ln=f.ReadLine())!= null)
            {
                string[] data = ln.Split(',');
                if(username == data[0])
                {
                    f.Close();
                    return true;
                }
            }
            f.Close();
            return false;
        }
        private void Registration()
        {
            username = textBox1.Text.Trim();
            password = textBox2.Text.Trim();
            if (UserExists())
            {
                MessageBox.Show("Izaberite drugo korisnicko ime.");
            }
            else {
                brojac = ReadID();
                StreamWriter f = File.AppendText("users.txt");
                f.WriteLine(username + ',' + password + ",korisnik" + ',' + brojac);
                f.Close();
                MessageBox.Show("Uspesna registracija!");
            }
            textBox1.Clear();
            textBox2.Clear();
        }
        private bool CheckIncorrectInput()
        {
            if (textBox1.Text.Contains(" ") || textBox1.Text == "" || textBox1.Text.Contains(','))
            {
                MessageBox.Show("Neispravno korisnicko ime.");
                textBox1.Clear();
                textBox1.Focus();
                return false;
            }
            if (textBox2.Text.Contains(" ") || textBox2.Text == "" || textBox2.Text.Contains(','))
            {
                MessageBox.Show("Neispravan password.");
                textBox2.Clear();
                textBox2.Focus();
                return false;
            }
            return true;
        }
        private void CheckLogin()
        {
            bool success = false;
            string line;
            bool admin = false;
            StreamReader file = new StreamReader("users.txt");
            while((line = file.ReadLine())!= null)
            {
                string[] podaci = line.Split(',');
                if((username == podaci[0]) && (password == podaci[1]))
                {
                    if(podaci[2].Equals("admin"))
                    {
                        admin = true;
                        MessageBox.Show("Admin");
                    }
                    MessageBox.Show("Uspesno");
                    success = true;
                }
            }
            file.Close();
            if (success)
            {
                if (admin)
                {
                    k = new Administrator(username, password);
                    Form frm = new AdministratorForm();
                    frm.Show();
                    this.Hide();
                    //FORMA ADMIN
                }
            }
            else
            {
                MessageBox.Show(username, password);
                k = new Kupac(username, password);
                Form frm = new UserForm();
                frm.Show();
                this.Hide();
                //FORMA KORISNIK
            }
        }
        private int ReadID()
        {
            int id;
            string lastLine = File.ReadLines("users.txt").LastOrDefault();
            char c = '\0';
            if (lastLine != null)
                c = lastLine.LastOrDefault();
            id = (int)Char.GetNumericValue(c);
            id++;
            return id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckIncorrectInput())
            {
                CheckLogin();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckIncorrectInput())
            {
                Registration();
            }
        }
        private void StartForm_Load(object sender, System.EventArgs e)
        {
        }
    }
}
