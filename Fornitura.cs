using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioMusicale
{
    public class Fornitura
    {
        public int FornitoreCodice { get; set; }
        public int SupportoID { get; set; }
        public int Quantita { get; set; }
        public decimal CostoAcquisto { get; set; }
    }

}
