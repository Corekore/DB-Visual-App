using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class IstoricShow
    {
        public int CONTRACTID { get; set; }
        public int CLIENTID { get; set; }
        public string TipContract{ get; set; }
        public string DataDeschidere { get; set; }
        public string StareContract { get; set; }
        public string IstoricInfo // toate informatiile despre istoric
        {
            get
            {
                return $"{ CONTRACTID } { CLIENTID } { TipContract } { DataDeschidere } { StareContract }";
            }
        }
    }
}
