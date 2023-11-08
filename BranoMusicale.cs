using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioMusicale
{
    public class BranoMusicale
    {
        public int Codice { get; set; }
        public string Titolo { get; set; }
        public string Genere { get; set; }
        public TimeSpan Durata { get; set; }
        public SupportoMusicale Supporto { get; set; }
    }

}
