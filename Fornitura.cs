using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioMusicale
{
    public class Fornitura
    {
        public Fornitore Fornitore { get; set; }
        public SupportoMusicale Supporto { get; set; }
        public int Quantita { get; set; }
        public decimal CostoAcquisto { get; set; }
    }

}
