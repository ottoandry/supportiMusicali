using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioMusicale
{
    public class Cliente
    {
        public int CodiceCliente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascita { get; set; }
        public string Indirizzo { get; set; }
    }

}
