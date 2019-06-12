using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_NRT4416
{
    class Korisnik
    {
        protected string username;
        protected string password;
        public Korisnik(string u,string p)
        {
            this.username = u;
            this.password = p;
        }
    }
}
