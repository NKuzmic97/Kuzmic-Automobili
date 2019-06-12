using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_NRT4416
{
    class Automobil
    {
        private int id;
        private string marka;
        private string model;
        private int kubikaza;
        private int god_proizvodnje;
        private string pogon;
        private string menjac;
        private string karoserija;
        private string gorivo;
        private int broj_vrata;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Marka
        {
            get
            {
                return marka;
            }

            set
            {
                marka = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public int Kubikaza
        {
            get
            {
                return kubikaza;
            }

            set
            {
                kubikaza = value;
            }
        }

        public int God_proizvodnje
        {
            get
            {
                return god_proizvodnje;
            }

            set
            {
                god_proizvodnje = value;
            }
        }

        public string Pogon
        {
            get
            {
                return pogon;
            }

            set
            {
                pogon = value;
            }
        }

        public string Menjac
        {
            get
            {
                return menjac;
            }

            set
            {
                menjac = value;
            }
        }

        public string Karoserija
        {
            get
            {
                return karoserija;
            }

            set
            {
                karoserija = value;
            }
        }

        public string Gorivo
        {
            get
            {
                return gorivo;
            }

            set
            {
                gorivo = value;
            }
        }

        public int Broj_vrata
        {
            get
            {
                return broj_vrata;
            }

            set
            {
                broj_vrata = value;
            }
        }

        public Automobil(int id,string marka, string model, int kubikaza, int god_proizvodnje, string pogon, string menjac, string karoserija, string gorivo, int broj_vrata)
        {
            this.Id = id;
            this.Marka = marka;
            this.Model = model;
            this.Kubikaza = kubikaza;
            this.God_proizvodnje = god_proizvodnje;
            this.Pogon = pogon;
            this.Menjac = menjac;
            this.Karoserija = karoserija;
            this.Gorivo = gorivo;
            this.Broj_vrata = broj_vrata;
        }
        public string IspisiAutomobil()
        {
            return "Automobil je marke: " + Marka.ToString() + Environment.NewLine +
                "Model: " + Model.ToString() + Environment.NewLine +
                "Godiste: " + God_proizvodnje.ToString() + Environment.NewLine +
                "Pogon: " + Pogon.ToString() + Environment.NewLine +
                "Menjac: " + Menjac.ToString() + Environment.NewLine +
                "Karoserija: " + Karoserija.ToString() + Environment.NewLine +
                "Gorivo: " + Gorivo.ToString() + Environment.NewLine +
                "Broj vrata: " + Broj_vrata.ToString();
        }
        public string UpisUFajl()
        {
            return  Marka.ToString() + "," + Model.ToString() + "," + Kubikaza.ToString() + "," + God_proizvodnje.ToString() + "," + Pogon.ToString() +","+ Menjac.ToString() +"," + Karoserija.ToString() + "," + Gorivo.ToString() + "," + Broj_vrata.ToString() + "," + id.ToString();
        }
    }
}
