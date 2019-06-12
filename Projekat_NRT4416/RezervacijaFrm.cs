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
    public partial class RezervacijaFrm : Form
    {
        string line;
        int idTrenutogAuta;
        int idTrenutnogKupca;
        int cenaRezervacije = 0;
        int cenaPoDanu = 0;
        string username, password;
        private int BrojDana(DateTime date1, DateTime date2)
        {
            TimeSpan ts = date1 - date2;
            return ts.Days;
        }
        public void setId(string user,string pass,int id)
        {
            username = user;
            password = pass;
            idTrenutnogKupca = id;
        }
        public RezervacijaFrm()
        {
            InitializeComponent();
        }

        private void ObrisiSvaPolja()
        {
            modelBox.Items.Clear();
            modelBox.Text = "";
            kubikazaBox.Items.Clear();
            kubikazaBox.Text = "";
            godisteBox.Items.Clear();
            godisteBox.Text = "";
            pogonBox.Items.Clear();
            pogonBox.Text = "";
            menjacBox.Items.Clear();
            menjacBox.Text = "";
            karoserijaBox.Items.Clear();
            karoserijaBox.Text = "";
            gorivoBox.Items.Clear();
            gorivoBox.Text = "";
            brojVrataBox.Items.Clear();
            brojVrataBox.Text = "";

        }
        private void UcitajMarku()
        {
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (!markaBox.Items.Contains(podaci[0]))
                    markaBox.Items.Add(podaci[0]);
            }
        }
        private void RezervacijaFrm_Load(object sender, EventArgs e)
        {
            UcitajMarku();
        }

        private void modelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[0] == markaBox.GetItemText(markaBox.SelectedItem) && podaci[1] == modelBox.GetItemText(modelBox.SelectedItem))
                {
                    if (!kubikazaBox.Items.Contains(podaci[2]))
                        kubikazaBox.Items.Add(podaci[2]);
                }

            }
            file.Close();
        }

        private void kubikazaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[0] == markaBox.GetItemText(markaBox.SelectedItem) && podaci[1] == modelBox.GetItemText(modelBox.SelectedItem) && podaci[2] == kubikazaBox.GetItemText(kubikazaBox.SelectedItem))
                {
                    if (!godisteBox.Items.Contains(podaci[3]))
                        godisteBox.Items.Add(podaci[3]);
                }

            }
            file.Close();
        }

        private void godisteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[0] == markaBox.GetItemText(markaBox.SelectedItem) && podaci[1] == modelBox.GetItemText(modelBox.SelectedItem) && podaci[2] == kubikazaBox.GetItemText(kubikazaBox.SelectedItem) && podaci[3] == godisteBox.GetItemText(godisteBox.SelectedItem))
                {
                    if (!pogonBox.Items.Contains(podaci[4]))
                        pogonBox.Items.Add(podaci[4]);
                }

            }
            file.Close();
        }

        private void pogonBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[0] == markaBox.GetItemText(markaBox.SelectedItem) && podaci[1] == modelBox.GetItemText(modelBox.SelectedItem) && podaci[2] == kubikazaBox.GetItemText(kubikazaBox.SelectedItem) && podaci[3] == godisteBox.GetItemText(godisteBox.SelectedItem) && podaci[4] == pogonBox.GetItemText(pogonBox.SelectedItem))
                {
                    if (!menjacBox.Items.Contains(podaci[5]))
                        menjacBox.Items.Add(podaci[5]);
                }

            }
            file.Close();
        }

        private void menjacBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[0] == markaBox.GetItemText(markaBox.SelectedItem) && podaci[1] == modelBox.GetItemText(modelBox.SelectedItem) && podaci[2] == kubikazaBox.GetItemText(kubikazaBox.SelectedItem) && podaci[3] == godisteBox.GetItemText(godisteBox.SelectedItem) && podaci[4] == pogonBox.GetItemText(pogonBox.SelectedItem) && podaci[5] == menjacBox.GetItemText(menjacBox.SelectedItem))
                {
                    if (!karoserijaBox.Items.Contains(podaci[6]))
                        karoserijaBox.Items.Add(podaci[6]);
                }

            }
            file.Close();
        }

        private void karoserijaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[0] == markaBox.GetItemText(markaBox.SelectedItem) && podaci[1] == modelBox.GetItemText(modelBox.SelectedItem) && podaci[2] == kubikazaBox.GetItemText(kubikazaBox.SelectedItem) && podaci[3] == godisteBox.GetItemText(godisteBox.SelectedItem) && podaci[4] == pogonBox.GetItemText(pogonBox.SelectedItem) && podaci[5] == menjacBox.GetItemText(menjacBox.SelectedItem) && podaci[6] == karoserijaBox.GetItemText(karoserijaBox.SelectedItem))
                {
                    if (!gorivoBox.Items.Contains(podaci[7]))
                        gorivoBox.Items.Add(podaci[7]);
                }

            }
            file.Close();
        }

        private void gorivoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[0] == markaBox.GetItemText(markaBox.SelectedItem) && podaci[1] == modelBox.GetItemText(modelBox.SelectedItem) && podaci[2] == kubikazaBox.GetItemText(kubikazaBox.SelectedItem) && podaci[3] == godisteBox.GetItemText(godisteBox.SelectedItem) && podaci[4] == pogonBox.GetItemText(pogonBox.SelectedItem) && podaci[5] == menjacBox.GetItemText(menjacBox.SelectedItem) && podaci[6] == karoserijaBox.GetItemText(karoserijaBox.SelectedItem) && podaci[7] == gorivoBox.GetItemText(gorivoBox.SelectedItem))
                {
                    if (!brojVrataBox.Items.Contains(podaci[8]))
                        brojVrataBox.Items.Add(podaci[8]);
                }

            }
            file.Close();
        }

        private void brojVrataBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[0] == markaBox.GetItemText(markaBox.SelectedItem) && podaci[1] == modelBox.GetItemText(modelBox.SelectedItem) && podaci[2] == kubikazaBox.GetItemText(kubikazaBox.SelectedItem) && podaci[3] == godisteBox.GetItemText(godisteBox.SelectedItem) && podaci[4] == pogonBox.GetItemText(pogonBox.SelectedItem) && podaci[5] == menjacBox.GetItemText(menjacBox.SelectedItem) && podaci[6] == karoserijaBox.GetItemText(karoserijaBox.SelectedItem) && podaci[7] == gorivoBox.GetItemText(gorivoBox.SelectedItem) && podaci[8] == brojVrataBox.GetItemText(brojVrataBox.SelectedItem))
                {
                    if (idTrenutogAuta == 0)
                        idTrenutogAuta = int.Parse(podaci[9]);
                }
            }
            file.Close();
                }

        private void markaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObrisiSvaPolja();
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[0] == markaBox.GetItemText(markaBox.SelectedItem))
                {
                    if (!modelBox.Items.Contains(podaci[1]))
                        modelBox.Items.Add(podaci[1]);
                }
            }
            file.Close();
        }

        private void rezervisiBtn_Click(object sender, EventArgs e)
        {
            StreamWriter f = File.AppendText("rezervacije.txt");
            f.WriteLine(idTrenutogAuta.ToString() + ',' + idTrenutnogKupca.ToString() + ',' + datumPreuzimanjaDtp.Value.ToString("dd.MM.yyyy") + ',' + datumVracanjaDtp.Value.ToString("dd.MM.yyyy") + ',' + cenaRezervacije);
            f.Close();
            MessageBox.Show("Uspesan upis rezervacije u datoteku!");
            UserForm frm = new UserForm();
            frm.LoadUsernamePassword(username,password,idTrenutnogKupca);
            frm.Show();
            this.Hide();
        }

        private void prikaziTermineBtn_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("ponude.txt");
            MessageBox.Show(idTrenutogAuta.ToString());
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[0] == idTrenutogAuta.ToString())
                {
                    textBox1.Text += podaci[1] + " do: " + podaci[2];
                }
            }
        }

        private void datumVracanjaDtp_ValueChanged(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("ponude.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[0] == idTrenutogAuta.ToString())
                {
                    cenaPoDanu = int.Parse(podaci[3]);
                }
            }
            cenaRezervacije = BrojDana(datumVracanjaDtp.Value, datumPreuzimanjaDtp.Value) * cenaPoDanu;
            textBox2.Text = cenaRezervacije.ToString();
            file.Close();
        }
    }
}
