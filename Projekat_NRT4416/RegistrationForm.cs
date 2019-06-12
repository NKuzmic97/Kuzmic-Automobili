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
    public partial class RegistrationForm : Form
    {
        private string username;
        private string password;
        private string jmbg;
        private string ime;
        private string prezime;
        private string br_telefona;
        private DateTime dat_rodj;
        private int brojac;

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        private void BackLogin()
        {
            Form frm = new LoginForm();
            frm.Show();
            this.Hide();
        }
        private bool CheckIncorrectRegistration()
        {
            username = usrnmBox.Text;
            password = pswdBox.Text;
            jmbg = jmbgBox.Text;
            ime = nameBox.Text;
            prezime = srnmBox.Text;
            br_telefona = phoneBox.Text;
            dat_rodj = DOB.Value;

            if (usrnmBox.Text.Contains(" ") || usrnmBox.Text == "" || usrnmBox.Text.Contains(','))
            {
                MessageBox.Show("Neispravno korisnicko ime.");
                usrnmBox.Clear();
                usrnmBox.Focus();
                return false;
            }
            if (pswdBox.Text.Contains(" ") || pswdBox.Text == "" || pswdBox.Text.Contains(','))
            {
                MessageBox.Show("Neispravan password.");
                pswdBox.Clear();
                pswdBox.Focus();
                return false;
            }
            if (jmbgBox.Text.Contains(" ") || jmbgBox.Text == "" || jmbgBox.Text.Contains(',') || !IsDigitsOnly(jmbgBox.Text))
            {
                MessageBox.Show("Neispravan JMBG. Unosite samo cifre!");
                jmbgBox.Clear();
                jmbgBox.Focus();
                return false;
            }
            if (nameBox.Text.Contains(" ") || nameBox.Text == "" || nameBox.Text.Contains(','))
            {
                MessageBox.Show("Neispravno ime.");
                nameBox.Clear();
                nameBox.Focus();
                return false;
            }
            if (srnmBox.Text.Contains(" ") || srnmBox.Text == "" || srnmBox.Text.Contains(','))
            {
                MessageBox.Show("Neispravno prezime.");
                srnmBox.Clear();
                srnmBox.Focus();
                return false;
            }
            if (phoneBox.Text.Contains(" ") || phoneBox.Text == "" || phoneBox.Text.Contains(',') || !IsDigitsOnly(phoneBox.Text))
            {
                MessageBox.Show("Neispravan broj telefona. Unosite samo cifre!");
                srnmBox.Clear();
                srnmBox.Focus();
                return false;
            }
            return true;
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
        private void ClearTextboxes()
        {
            usrnmBox.Clear();
            pswdBox.Clear();
            jmbgBox.Clear();
            nameBox.Clear();
            srnmBox.Clear();
            phoneBox.Clear();
        }
        private bool UserExists()
        {
            string ln;
            StreamReader f = new StreamReader("users.txt");
            while ((ln = f.ReadLine()) != null)
            {
                string[] data = ln.Split(',');
                if (username == data[0])
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
            if (UserExists())
            {
                MessageBox.Show("Izaberite drugo korisnicko ime.");
            }
            else {
                brojac = ReadID();
                StreamWriter f = File.AppendText("users.txt");
                f.WriteLine(username + ',' + password + ",korisnik" + ',' + ime.ToUpper() + ',' + prezime.ToUpper() + ',' + jmbg.ToString()+',' + br_telefona + ',' + dat_rodj.ToString("dd.MM.yyyy") + ',' + brojac);
                f.Close();
                MessageBox.Show("Uspesna registracija!");
            }
            ClearTextboxes();
        }
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (CheckIncorrectRegistration())
            {
                Registration();
                BackLogin();
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            DOB.Format = DateTimePickerFormat.Custom;
            DOB.CustomFormat = "dd.MM.yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackLogin();
        }
    }
}
