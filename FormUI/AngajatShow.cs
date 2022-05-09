using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class AngajatShow
    {
        public int ANGAJATID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int CLIENTID { get; set; }
        public string AngajatInfo // toate informatiile despre angajat
        {
            get
            {
                return $"{ ANGAJATID } { Nume } { Prenume } { CLIENTID }";
            }
        }

    }

}