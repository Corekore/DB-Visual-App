using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Client
    {
        public int CLIENTID { get; set; }
        public int REPREZENTANTID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public string Strada { get; set; }
        public string Numar { get; set; }
        public string Oras { get; set; }
        public string Sex { get; set; }
        public string DataNasterii { get; set; }
        //public int DOCUMENTEID { get; set; }
        //public int CONTRACTID { get; set; }

        public string NumeClientInfo //informatiile pe care le primesc cand introduc un nume al unui client
        {
            get 
            {
                // Radu Cristian CNP
                return $"{ Nume } { Prenume } ({CNP})";
            }
           
        }
        public string ClientInfo //informatiile pe care le primesc cand apas search all
        {
            get
            {
                // Radu Cristian CNP
                return $"{ CLIENTID } {REPREZENTANTID} { Nume } { Prenume } {CNP} { Strada } { Numar } { Oras } { Sex } { DataNasterii }";
            }

        }
        public string SimpleInfo1 //simple info 1
        {
            get
            {
                // Radu Cristian 
                return $"{ Nume } { Prenume }";
            }

        }
    }
}
