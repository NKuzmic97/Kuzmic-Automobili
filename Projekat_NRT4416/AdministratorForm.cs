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
using System.Globalization;

namespace Projekat_NRT4416
{
    public partial class AdministratorForm : Form
    {

        Automobil a;
        string line;
        int idTrenutogKupca = 0;
        int idTrenutogAuta = 0;
        string username;
        string password;
        bool unos = true;

        private int BrojDana(DateTime date1, DateTime date2)
        {
            TimeSpan ts = date1 - date2;
            return ts.Days;
        }
        private int ReadIDLine(string fajl,int index,int trenutniID)
        {
            int brojac = 0;
            StreamReader file = new StreamReader(fajl);
            while ((line = file.ReadLine()) != null)
            {
                brojac++;
                string[] podaci = line.Split(',');
                if (podaci[index] == trenutniID.ToString())
                {
                    file.Close();
                    return brojac - 1;
                }

            }
            file.Close();
            return 0;
            
        }
        private int ReadRezervacijeLine(string fajl, string[] sadrzaj)
        {
            int brojac = 0;
            StreamReader file = new StreamReader(fajl);
            while ((line = file.ReadLine()) != null)
            {
                brojac++;
                string[] podaci = line.Split(',');
                if (podaci[0] == sadrzaj[0] && podaci[1]==sadrzaj[1]&&podaci[2] == sadrzaj[2] && podaci[3] == sadrzaj[3] && podaci[4] == sadrzaj[4])
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
        public int ReadID()
        {
            int id;
            string lastLine = File.ReadLines("automobili.txt").LastOrDefault();
            string[] podaci = lastLine.Split(',');
            id = int.Parse(podaci[9].ToString());
            id++;
            return id;
        }
        private void UcitajKupce()
        {
            kupacBox.Items.Clear();
            StreamReader file = new StreamReader("users.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[2] == "korisnik")
                    kupacBox.Items.Add(podaci[3] + " " + podaci[4] + " ID: " + podaci[8]);
            }
            file.Close();
        }
        private bool CheckFilled()
        {
            if(string.IsNullOrEmpty(markaBox.Text) || 
                string.IsNullOrEmpty(modelBox.Text) ||
                string.IsNullOrEmpty(kubikazaBox.Text) ||
                string.IsNullOrEmpty(godprBox.Text) ||
                string.IsNullOrEmpty(pogonBox.Text) ||
                string.IsNullOrEmpty(menjacBox.Text) ||
                string.IsNullOrEmpty(karoBox.Text) ||
                string.IsNullOrEmpty(gorBox.Text) ||
                string.IsNullOrEmpty(brvrBox.Text)){
                return false;
            }
            return true;
        }
        private void ClearComboboxesCar()
        {
            markaBox.Text = "";
            modelBox.Text = "";
            kubikazaBox.Text = "";
            godprBox.Text = "";

            modelBox.Items.Clear();
            kubikazaBox.Items.Clear();
            godprBox.Items.Clear();
            pogonBox.Items.Clear();
            menjacBox.Items.Clear();
            karoBox.Items.Clear();
            gorBox.Items.Clear();
            brvrBox.Items.Clear();
        }
        private void ClearTextboxesKupac() {
            imeBox.Text = "";
            prezBox.Text = "";
            jmbgBox.Text = "";
            telefonBox.Text = "";
            dtpBox.Value = DateTime.Now;
        }
        /*private void EditCar(string edited_data,int car_id)
        {
            string[] temp = File.ReadAllLines("automobili.txt");
            temp[car_id] = edited_data;
            File.WriteAllLines("automobili.txt", temp);
        }*/
        private void UcitajAutomobilePonuda()
        {
            autoPonudaBox.Items.Clear();
            trenutnePonudeBox.Items.Clear();
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                    autoPonudaBox.Items.Add(podaci[0] + " " + podaci[1] + " ID: " + podaci[9]);
            }
            file.Close();
            file = new StreamReader("ponude.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                trenutnePonudeBox.Items.Add(podaci[0] + "_" + podaci[1] + "_" + podaci[2] + "_" + podaci[3]);
            }
            file.Close();
        }

        private void UcitajRezervacije()
        {
            trenutneRezervacijeBox.Items.Clear();
            StreamReader file = new StreamReader("rezervacije.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                MessageBox.Show(podaci[1]);
                if (idTrenutogKupca.ToString() == podaci[1])
                {
                    trenutneRezervacijeBox.Items.Add(podaci[0] + '_' + podaci[1] + '_' + podaci[2] + '_' + podaci[3] + '_' + podaci[4]);
                }
            }
            file.Close();
        }
        private void OnLoad()
        {
            markaBox.Items.Clear();
            if (unos)
            {
                string[] temp = new string[] { "PREDNJI", "ZADNJI", "4x4" };
                foreach (string p in temp)
                {
                    pogonBox.Items.Add(p);
                }
                temp = new string[] { "5 BRZINA", "6 BRZINA", "AUTOMATIK" };
                foreach (string p in temp)
                {
                    menjacBox.Items.Add(p);
                }
                temp = new string[] { "LIMUZINA", "HECBEK", "KARAVAN", "KUPE", "KABRIO" };
                foreach (string p in temp)
                {
                    karoBox.Items.Add(p);
                }
                temp = new string[] { "BENZIN", "DIZEL", "TNG", "CNG", "HIBRID" };
                foreach (string p in temp)
                {
                    gorBox.Items.Add(p);
                }
                temp = new string[] { "3", "5" };
            
                foreach (string p in temp)
                {
                    brvrBox.Items.Add(p);
                }
            }

            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if(!markaBox.Items.Contains(podaci[0]))
                markaBox.Items.Add(podaci[0]);
            }
            file.Close();
            UcitajAutomobilePonuda();
        }
        public AdministratorForm()
        {
            InitializeComponent();
        }
        private void PodesiDTP()
        {
            dtpBox.Format = DateTimePickerFormat.Custom;
            dtpBox.CustomFormat = "dd.MM.yyyy";

            odDatDtp.Format = DateTimePickerFormat.Custom;
            odDatDtp.CustomFormat = "dd.MM.yyyy";

            doDatDtp.Format = DateTimePickerFormat.Custom;
            doDatDtp.CustomFormat = "dd.MM.yyyy";

            rezOdDtp.Format = DateTimePickerFormat.Custom;
            rezOdDtp.CustomFormat = "dd.MM.yyyy";

            rezDoDtp.Format = DateTimePickerFormat.Custom;
            rezDoDtp.CustomFormat = "dd.MM.yyyy";

            odDatDtp.MinDate = DateTime.Today;
            odDatDtp.Value = DateTime.Today;
            doDatDtp.MaxDate = odDatDtp.Value.AddMonths(2);
            doDatDtp.Value = doDatDtp.MaxDate;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (a != null)
            {
                textBox1.Text = a.IspisiAutomobil();
                StreamWriter f = File.AppendText("automobili.txt");
                f.WriteLine(a.UpisUFajl());
                f.Close();
                MessageBox.Show("Uspesan upis automobila u datoteku!");
                a = null;
                ClearComboboxesCar();
                OnLoad();
            }
            else {
                MessageBox.Show("Nijedan automobil nije unet!"); textBox1.Text = "";
            }
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            OnLoad();
            UcitajKupce();
            PodesiDTP();
        }

        private void markaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelBox.Items.Clear();
            modelBox.Text = "";
            kubikazaBox.Items.Clear();
            kubikazaBox.Text = "";
            godprBox.Items.Clear();
            godprBox.Text = "";

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
                    if (!godprBox.Items.Contains(podaci[3]))
                        godprBox.Items.Add(podaci[3]);
                }

            }
            file.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ClearComboboxesCar();
            markaBox.DropDownStyle = ComboBoxStyle.DropDown;
            modelBox.DropDownStyle = ComboBoxStyle.DropDown;
            kubikazaBox.DropDownStyle = ComboBoxStyle.DropDown;
            godprBox.DropDownStyle = ComboBoxStyle.DropDown;
            pogonBox.DropDownStyle = ComboBoxStyle.DropDownList;
            menjacBox.DropDownStyle = ComboBoxStyle.DropDownList;
            karoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            gorBox.DropDownStyle = ComboBoxStyle.DropDownList;
            brvrBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OnLoad();
        }

        private void godprBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[0] == markaBox.GetItemText(markaBox.SelectedItem) && podaci[1] == modelBox.GetItemText(modelBox.SelectedItem) && podaci[2] == kubikazaBox.GetItemText(kubikazaBox.SelectedItem) && podaci[3] == godprBox.GetItemText(godprBox.SelectedItem))
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
                if (podaci[0] == markaBox.GetItemText(markaBox.SelectedItem) && podaci[1] == modelBox.GetItemText(modelBox.SelectedItem) && podaci[2] == kubikazaBox.GetItemText(kubikazaBox.SelectedItem) && podaci[3] == godprBox.GetItemText(godprBox.SelectedItem)  && podaci[4] == pogonBox.GetItemText(pogonBox.SelectedItem))
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
                if (podaci[0] == markaBox.GetItemText(markaBox.SelectedItem) && podaci[1] == modelBox.GetItemText(modelBox.SelectedItem) && podaci[2] == kubikazaBox.GetItemText(kubikazaBox.SelectedItem) && podaci[3] == godprBox.GetItemText(godprBox.SelectedItem)  && podaci[4] == pogonBox.GetItemText(pogonBox.SelectedItem) && podaci[5] == menjacBox.GetItemText(menjacBox.SelectedItem))
                {
                    if (!karoBox.Items.Contains(podaci[6]))
                        karoBox.Items.Add(podaci[6]);
                }

            }
            file.Close();
        }

        private void karoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[0] == markaBox.GetItemText(markaBox.SelectedItem) && podaci[1] == modelBox.GetItemText(modelBox.SelectedItem) && podaci[2] == kubikazaBox.GetItemText(kubikazaBox.SelectedItem) && podaci[3] == godprBox.GetItemText(godprBox.SelectedItem)  && podaci[4] == pogonBox.GetItemText(pogonBox.SelectedItem) && podaci[5] == menjacBox.GetItemText(menjacBox.SelectedItem) && podaci[6] == karoBox.GetItemText(karoBox.SelectedItem))
                {
                    if (!gorBox.Items.Contains(podaci[7]))
                        gorBox.Items.Add(podaci[7]);
                }

            }
            file.Close();
        }

        private void gorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[0] == markaBox.GetItemText(markaBox.SelectedItem) && podaci[1] == modelBox.GetItemText(modelBox.SelectedItem) && podaci[2] == kubikazaBox.GetItemText(kubikazaBox.SelectedItem) && podaci[3] == godprBox.GetItemText(godprBox.SelectedItem)  && podaci[4] == pogonBox.GetItemText(pogonBox.SelectedItem) && podaci[5] == menjacBox.GetItemText(menjacBox.SelectedItem) && podaci[6] == karoBox.GetItemText(karoBox.SelectedItem) && podaci[7] == gorBox.GetItemText(gorBox.SelectedItem))
                {
                    if (!brvrBox.Items.Contains(podaci[8]))
                        brvrBox.Items.Add(podaci[8]);
                }

            }
            file.Close();
        }

        private void kupacBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            char tmp = kupacBox.Text.LastOrDefault();
            idTrenutogKupca = (int)Char.GetNumericValue(tmp);

            StreamReader file = new StreamReader("users.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[8] == idTrenutogKupca.ToString())
                {
                    username = podaci[0];
                    password = podaci[1];
                    imeBox.Text = podaci[3];
                    prezBox.Text = podaci[4];
                    jmbgBox.Text = podaci[5];
                    telefonBox.Text = podaci[6];
                    dtpBox.Value = DateTime.ParseExact(podaci[7], "dd.MM.yyyy",CultureInfo.InvariantCulture);
                }
            }
            file.Close();
            UcitajRezervacije();
        }

        private void izmeniKupcaBtn_Click(object sender, EventArgs e)
        {
            if (idTrenutogKupca != 0)
            {
                ChangeLine((username + ',' + password + ',' + "korisnik" + ',' + imeBox.Text.ToUpper() + ',' + prezBox.Text.ToUpper() + ',' + jmbgBox.Text.ToUpper() + ',' + telefonBox.Text + ',' + dtpBox.Value.ToString("dd.MM.yyyy") + ',' + idTrenutogKupca.ToString()), "users.txt", ReadIDLine("users.txt", 8, idTrenutogKupca));
                MessageBox.Show("Kupac uspesno izmenjen!");
            }
            UcitajKupce();
            ClearTextboxesKupac();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            unos = false;
            ClearComboboxesCar();
            markaBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modelBox.DropDownStyle = ComboBoxStyle.DropDownList;
            kubikazaBox.DropDownStyle = ComboBoxStyle.DropDownList;
            godprBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pogonBox.DropDownStyle = ComboBoxStyle.DropDownList;
            menjacBox.DropDownStyle = ComboBoxStyle.DropDownList;
            karoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            gorBox.DropDownStyle = ComboBoxStyle.DropDownList;
            brvrBox.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void brvrBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("automobili.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] podaci = line.Split(',');
                if (podaci[0] == markaBox.GetItemText(markaBox.SelectedItem) && podaci[1] == modelBox.GetItemText(modelBox.SelectedItem) && podaci[2] == kubikazaBox.GetItemText(kubikazaBox.SelectedItem) && podaci[3] == godprBox.GetItemText(godprBox.SelectedItem) && podaci[4] == pogonBox.GetItemText(pogonBox.SelectedItem) && podaci[5] == menjacBox.GetItemText(menjacBox.SelectedItem) && podaci[6] == karoBox.GetItemText(karoBox.SelectedItem) && podaci[7] == gorBox.GetItemText(gorBox.SelectedItem) && podaci[8] == brvrBox.GetItemText(brvrBox.SelectedItem))
                {
                    if(idTrenutogAuta == 0)
                        idTrenutogAuta = int.Parse(podaci[9]);

                    if (izmenaRBox.Checked)
                    {
                        markaBox.DropDownStyle = ComboBoxStyle.DropDown;
                        modelBox.DropDownStyle = ComboBoxStyle.DropDown;
                        kubikazaBox.DropDownStyle = ComboBoxStyle.DropDown;
                        godprBox.DropDownStyle = ComboBoxStyle.DropDown;
                        pogonBox.DropDownStyle = ComboBoxStyle.DropDownList;
                        menjacBox.DropDownStyle = ComboBoxStyle.DropDownList;
                        karoBox.DropDownStyle = ComboBoxStyle.DropDownList;
                        gorBox.DropDownStyle = ComboBoxStyle.DropDownList;
                        brvrBox.DropDownStyle = ComboBoxStyle.DropDownList;
                        pogonBox.Items.Clear();
                        menjacBox.Items.Clear();
                        karoBox.Items.Clear();
                        gorBox.Items.Clear();
                        brvrBox.Items.Clear();
                        string[] temp = new string[] { "PREDNJI", "ZADNJI", "4x4" };
                        foreach (string p in temp)
                        {
                            pogonBox.Items.Add(p);
                        }
                        temp = new string[] { "5 BRZINA", "6 BRZINA", "AUTOMATIK" };
                        foreach (string p in temp)
                        {
                            menjacBox.Items.Add(p);
                        }
                        temp = new string[] { "LIMUZINA", "HECBEK", "KARAVAN", "KUPE", "KABRIO" };
                        foreach (string p in temp)
                        {
                            karoBox.Items.Add(p);
                        }
                        temp = new string[] { "BENZIN", "DIZEL", "TNG", "CNG", "HIBRID" };
                        foreach (string p in temp)
                        {
                            gorBox.Items.Add(p);
                        }
                        temp = new string[] { "3", "5" };

                        foreach (string p in temp)
                        {
                            brvrBox.Items.Add(p);
                        }
                    }
                }

            }
            file.Close();
        }

        private void obrisiAutoBtn_Click(object sender, EventArgs e)
        {
            if (idTrenutogAuta != 0 && !unos)
            {
                ChangeLine("", "automobili.txt", ReadIDLine("automobili.txt",9,idTrenutogAuta));
                MessageBox.Show("Automobil obrisan iz baze.");
                ClearComboboxesCar();
                CleanBlankLines("automobili.txt");
                OnLoad();
                idTrenutogAuta = 0;
            }
            else
                MessageBox.Show("Greska u brisanju automobila.");
        }

        private void obrisiKupcaBtn_Click(object sender, EventArgs e)
        {
            if (idTrenutogKupca != 0)
            {
                ChangeLine("", "users.txt", ReadIDLine("users.txt",8,idTrenutogKupca));
                MessageBox.Show("Kupac obrisan iz baze.");
                ClearTextboxesKupac();
                CleanBlankLines("users.txt");
                UcitajKupce();
            }
            else
                MessageBox.Show("Greska u brisanju kupca.");
        }

        private void IzmeniAutoBtn_Click(object sender, EventArgs e)
        {
            if (izmenaRBox.Checked == true)
            {

                if (idTrenutogAuta != 0)
                {
                    ChangeLine((markaBox.Text.ToUpper() + ',' + modelBox.Text.ToUpper() + ',' + kubikazaBox.Text.ToUpper() + ',' + godprBox.Text.ToUpper() + ',' + pogonBox.Text.ToUpper() + ',' + menjacBox.Text.ToUpper() + ',' + karoBox.Text + ',' + gorBox.Text + ',' + brvrBox.Text + ',' + idTrenutogAuta.ToString()), "automobili.txt", ReadIDLine("automobili.txt", 9, idTrenutogAuta));
                    MessageBox.Show("Automobil uspesno izmenjen!");
                    idTrenutogAuta = 0;
                    ClearComboboxesCar();
                    OnLoad();
                    radioButton1.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Greska u izmeni automobila. Da li ste popunili sva polja i stiklirali Izmena?");
            }
        }

        private void izmenaRBox_CheckedChanged(object sender, EventArgs e)
        {
            ClearComboboxesCar();
            markaBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modelBox.DropDownStyle = ComboBoxStyle.DropDownList;
            kubikazaBox.DropDownStyle = ComboBoxStyle.DropDownList;
            godprBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pogonBox.DropDownStyle = ComboBoxStyle.DropDownList;
            menjacBox.DropDownStyle = ComboBoxStyle.DropDownList;
            karoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            gorBox.DropDownStyle = ComboBoxStyle.DropDownList;
            brvrBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void UnosBtn_Click(object sender, EventArgs e)
        {
            if (CheckFilled())
            {
                a = new Automobil(ReadID(), markaBox.Text.ToUpper(), modelBox.Text.ToUpper(), int.Parse(kubikazaBox.Text), int.Parse(godprBox.Text), pogonBox.GetItemText(pogonBox.SelectedItem), menjacBox.GetItemText(menjacBox.SelectedItem), karoBox.GetItemText(karoBox.SelectedItem), gorBox.GetItemText(gorBox.SelectedItem), int.Parse(brvrBox.GetItemText(brvrBox.SelectedItem)));
                MessageBox.Show("Napravljen objekat tipa Automobil!");
            }
            else
                MessageBox.Show("Sva polja nisu popunjena!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idTrenutogAuta > 0)
            {
                StreamWriter f = File.AppendText("ponude.txt");
                f.WriteLine(idTrenutogAuta.ToString() + ',' + odDatDtp.Value.ToString("dd.MM.yyyy") + ',' + doDatDtp.Value.ToString("dd.MM.yyyy") + ',' + cenaPoDanu.Value.ToString());
                f.Close();
                MessageBox.Show("Uspesan upis ponude u datoteku!");
                idTrenutogAuta = -1;
                UcitajAutomobilePonuda();
            }
            else
                MessageBox.Show("Greska kod biranja automobila.");
            autoPonudaBox.Text = "";
        }
        private void autoPonudaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] podaci = autoPonudaBox.Text.Split(' ');

            if(autoPonudaBox.SelectedItem != null)
            idTrenutogAuta = int.Parse(podaci[podaci.Length - 1]);

            StreamReader file = new StreamReader("ponude.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] tmp = line.Split(',');
                if(idTrenutogAuta.ToString() == tmp[0])
                {
                    MessageBox.Show("Izabrani auto je vec ponudjen!");
                    idTrenutogAuta = -1;
                    autoPonudaBox.SelectedItem = null;
                }
                }
            file.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(trenutnePonudeBox.SelectedItem == null)
            {
                MessageBox.Show("Greska! Izaberite ponudu.");
            }
            else
            {
                ChangeLine("", "ponude.txt", trenutnePonudeBox.SelectedIndex);
                CleanBlankLines("ponude.txt");
                UcitajAutomobilePonuda();
                MessageBox.Show("Ponuda obrisana!");
            }
        }

        private void napRezBtn_Click(object sender, EventArgs e)
        {
            if(kupacBox.SelectedItem != null && trenutnePonudeBox.SelectedItem != null)
            {
                string[] line = trenutnePonudeBox.Text.Split('_');
                int cena = int.Parse(line[3]);
                int id_auta = int.Parse(line[0]);
                MessageBox.Show(id_auta.ToString());
                int cena_rezervacije = BrojDana(rezDoDtp.Value, rezOdDtp.Value) * cena;
                StreamWriter f = File.AppendText("rezervacije.txt");
                f.WriteLine(id_auta.ToString() + ',' + idTrenutogKupca.ToString() + ',' + rezOdDtp.Value.ToString("dd.MM.yyyy") + ',' + rezDoDtp.Value.ToString("dd.MM.yyyy") + ',' + cena_rezervacije);
                f.Close();
                MessageBox.Show("Uspesan upis rezervacije u datoteku!");
                UcitajRezervacije();
            }
            else
            {
                MessageBox.Show("Greska kod upisa rezervacije!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trenutnePonudeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] line = trenutnePonudeBox.Text.Split('_');
            rezOdDtp.MinDate = DateTime.Today;
            rezOdDtp.MaxDate = DateTime.ParseExact(line[2], "dd.MM.yyyy", CultureInfo.InvariantCulture);

            rezDoDtp.MinDate = rezOdDtp.MinDate.AddDays(2);
            rezDoDtp.MaxDate = DateTime.ParseExact(line[2], "dd.MM.yyyy", CultureInfo.InvariantCulture);
        }

        private void obrRezBtn_Click(object sender, EventArgs e)
        {
            if (trenutneRezervacijeBox.SelectedItem != null)
            {
                int broj_linije = ReadRezervacijeLine("rezervacije.txt", trenutneRezervacijeBox.Text.Split('_'));
                ChangeLine("", "rezervacije.txt", broj_linije);
                CleanBlankLines("rezervacije.txt");
                MessageBox.Show("Rezervacija obrisana.");
                UcitajRezervacije();
            }
            else
            {
                MessageBox.Show("Greska kod brisanja rezervacije.");
            }
        }
    }
}
