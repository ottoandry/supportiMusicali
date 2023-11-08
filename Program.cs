using NegozioMusicale;

class Program
{
    static void Main()
    {
        SupportoMusicale cd = new SupportoMusicale
        {
            ID = 1,
            Nome = "CD",
            Descrizione = "Album musicale su CD",
            PrezzoUnitario = 15.99m
        };

        List<BranoMusicale> brani = new List<BranoMusicale>
        {
            new BranoMusicale
            {
                Codice = 101,
                Titolo = "Hey Jude",
                Genere = "Rock",
                Durata = TimeSpan.FromMinutes(7),
                Supporto = cd
            },
            new BranoMusicale
            {
                Codice = 102,
                Titolo = "Let It Be",
                Genere = "Rock",
                Durata = TimeSpan.FromMinutes(4),
                Supporto = cd
            },
            new BranoMusicale
            {
                Codice = 103,
                Titolo = "Twist and Shout",
                Genere = "Rock",
                Durata = TimeSpan.FromMinutes(2),
                Supporto = cd
            }
        };

        Artista beatles = new Artista
        {
            NomeArte = "The Beatles",
            Biografia = "Leggendaria band di Liverpool",
            Nazionalita = "Regno Unito"
        };

        SupportoArtista supportoArtista = new SupportoArtista
        {
            Supporto = cd,
            ArtistaNomeArte = "The Beatles"
        };

        Cliente cliente = new Cliente
        {
            CodiceCliente = 1001,
            Nome = "Carmine",
            Cognome = "Liuzzi",
            Email = "info@carmineliuzzi.it",
            DataNascita = DateTime.Parse("1935-06-29"),
            Indirizzo = "Noci"
        };

        Ordine ordine = new Ordine
        {
            ID = 5001,
            DataOra = DateTime.Now,
            MetodoPagamento = "Carta di credito",
            IndirizzoSpedizione = "Viale Aldo Moro, Bari",
            Stato = "Elaborazione",
            Cliente = cliente
        };

        Fornitore emi = new Fornitore
        {
            CodiceFornitore = 2001,
            Nome = "EMI",
            PartitaIVA = "IT1234567890",
            Indirizzo = "Piccadilly, London"
        };

        Fornitura fornitura = new Fornitura
        {
            Fornitore = emi,
            Supporto = cd,
            Quantita = 100,
            CostoAcquisto = 10.50m
        };
    }
}
