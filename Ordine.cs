using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioMusicale
{
    public class Ordine
    {
        public int ID { get; set; }
        public DateTime DataOra { get; set; }
        public string MetodoPagamento { get; set; }
        public string IndirizzoSpedizione { get; set; }
        public string Stato { get; set; }
        public Cliente Cliente { get; set; }
    }

}
