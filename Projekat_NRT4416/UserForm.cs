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
    
    public partial class UserForm : Form
    {
        string username, password,datumOd,datumDo,cena;
        int IdTrenutnogKorisnika;
        int IdIzabranogAuta;
        Korisnik k;
        public UserForm()
        {
            InitializeComponent();
        }
        private int ReadRezervacijeLine(string fajl, string[] sadrzaj)
        {
            int brojac = 0;
            string line;
            StreamReader file = new StreamReader(fajl);
            while ((line = file.ReadLine()) != null)
            {
                brojac++;
                string[] podaci = line.Split(',');
                if (podaci[0] == sadrzaj[0] && podaci[1] == sadrzaj[1] && podaci[2] == sadrzaj[2] && podaci[3] == sadrzaj[3] && podaci[4] == sadrzaj[4])
                {
                    file.Close();
                    return brojac - 1;
                }

            }
            file.Close();
            return -1;
        }
        private void CleanBlankLines(string filename)
        {
            string[] text = File.ReadAllLines(filename).Where(s => s.Trim() != string.Empty).ToArray();
            File.Delete(filename);
            File.WriteAllLines(filename, text);
        }
        static void ChangeLine(string newText, string fileName, int line_to_edit)
        {
            //MessageBox.Show(line_to_edit.ToString());
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private void obrisiRezBtn_Click(object sender, EventArgs e)
        {
            if(trenutneRezBox.SelectedItem != null)
            {
                ChangeLine("", "rezervacije.txt", ReadRezervacijeLine("rezervacije.txt", trenutneRezBox.Text.Split('_')));
                CleanBlankLines("rezervacije.txt");
                MessageBox.Show("Rezervacija obrisana!");
                UcitajRezervacije();
            }
            else
            {
                MessageBox.Show("Greska u brisanju rezervacije.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RezervacijaFrm frm = new RezervacijaFrm();
            frm.setId(username,password,IdTrenutnogKorisnika);
            frm.Show();
            this.Hide();
        }

        private void trenutneRezBox_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }

        public void LoadUsernamePassword(string user,string pass,int id)
        {
            username = user;
            password = pass;
            IdTrenutnogKorisnika = id;
        }
        private void UcitajRezervacije()
        {
            trenutneRezBox.Items.Clear();
            string line;
            StreamReader file = new StreamReader("rezervacije.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (IdTrenutnogKorisnika.ToString() == podaci[1])
                {
                    trenutneRezBox.Items.Add(podaci[0] + '_' + podaci[1] + '_' + podaci[2] + '_' + podaci[3] + '_' + podaci[4]);
                    IdIzabranogAuta = int.Parse(podaci[0]);
                    datumOd = podaci[2];
                    datumDo = podaci[3];
                    cena = podaci[4];
                }
            }
            file.Close();
        }

        private void trenutneRezBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = "Vas automobil je: ";
            string line;
            string[] pom = trenutneRezBox.Text.Split('_');
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (pom[0] == podaci[9])
                {
                    textBox1.Text += podaci[0] + ' ' + podaci[1] + Environment.NewLine + podaci[2] + "cc " + podaci[3] + "god";
                }
            }
            textBox1.Text += Environment.NewLine + "Od: " + datumOd + " do: " + datumDo + Environment.NewLine + "Cena: " + cena;
            file.Close();


        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            k = new Kupac(username, password);
            label1.Text = "Dobrodosli, " + username + " !";
            MessageBox.Show(IdTrenutnogKorisnika.ToString());
            UcitajRezervacije();
        }
    }
}
