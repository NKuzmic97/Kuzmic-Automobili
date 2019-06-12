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
    public partial class LoginForm : Form
    {
        string username;
        string password;
        int id;
        static Korisnik k;

        public LoginForm()
        {
            InitializeComponent();
        }

        private bool CheckIncorrectLogin()
        {
            username = textBox1.Text;
            password = textBox2.Text;
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
        private void LoginCheck()
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
                    if(podaci[2] == "admin")
                    {
                        admin = true;
                    }
                    MessageBox.Show("Uspesan login!");
                    success = true;
                    id = int.Parse(podaci[8]);
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
                    //Otvara se forma za administratora.
                }

                else
                {
                    k = new Kupac(username, password);
                    UserForm frm = new UserForm();
                    frm.LoadUsernamePassword(username, password,id);
                    frm.Show();
                    this.Hide();
                    //Otvara se forma za korisnika.
                }
            }
            else
                MessageBox.Show("Neuspesan login. Pokusajte ponovo.");textBox1.Clear();textBox2.Clear();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckIncorrectLogin())
            {
                LoginCheck();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new RegistrationForm();
            frm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
