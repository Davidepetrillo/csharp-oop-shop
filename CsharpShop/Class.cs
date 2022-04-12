using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop
{
    internal class Prodotto
    {
        private long codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private int iva;


        public Prodotto(long codice, string nome, string descrizione, double prezzo, int iva)
        {
            this.codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        public long GetCodice()
        {
            Random random = new Random();
            long codice = random.Next(1000);
            return codice;
        }

        // ----- Fare getter e setter di tutte le variabili -----

        public string GetNome(string nuovoNome)
        {
            return nuovoNome;
        }
        public string SetNome(string nuovoNome)
        {
            return nuovoNome;
        }
        public string GetDescrizione (string nuovaDescrizione)
        {
            return nuovaDescrizione;
        }
        public string SetDescrizione(string nuovaDescrizione)
        {
            return nuovaDescrizione;
        }

        public double GetPrezzo (double nuovoPrezzo)
        {
            return nuovoPrezzo;
        }
        public double SetPrezzo(double nuovoPrezzo)
        {
            return nuovoPrezzo;
        }

        public int GetIva(int nuovoIva)
        {
            return nuovoIva;
        }


        public double PrezzoPiuIva(double prezzo, int iva)
        {
            double prezzoFinale = prezzo + ((prezzo * iva) / 100);
            return prezzoFinale;
        }

        public void Identificativo(long codice, string nome)
        {
            Console.WriteLine($"Codice identificativo: {codice}-{nome}");
        }

        private void CodiceConPadding()
        {
            string codiceInStringa = codice.ToString();
            char zero = '0';
            Console.WriteLine($"Codice con Pad: {codiceInStringa.PadLeft(8, zero)}");
        }

        public void StampaProdotto()
        {
            Console.WriteLine("----- Prodotto -------");
            Console.WriteLine("Codice: " + codice);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Descrizione: " + descrizione);
            Console.WriteLine($"Prezzo: {prezzo} euro");
            Console.WriteLine($"IVA: {iva}%");
            Console.WriteLine($"Prezzo finale: {PrezzoPiuIva(prezzo, iva)} euro");
            Identificativo(codice, nome);
            CodiceConPadding();
            Console.WriteLine("------------------");

        }

    }
}
