using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class DocumenteShow
    {
        public int DOCUMENTEID { get; set; }
        public string Buletin { get; set; }
        public string ARC { get; set; }
        public string ActeJuridice { get; set; }
        public string AdeverintaSalariat { get; set; }
        public string ContractAngajator { get; set; }
        public string AlteActe { get; set; }

        public string DocumenteInfo // toate informatiile despre documente
        {
            get
            {
                return $"{ DOCUMENTEID } { Buletin } { ARC } { ActeJuridice } { AdeverintaSalariat } { ContractAngajator } { AlteActe }";
            }
        }
    }
}
