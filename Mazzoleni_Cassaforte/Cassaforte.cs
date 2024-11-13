using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazzoleni_Cassaforte
{
    class Cassaforte
    {
        private int numMatricola;
        private string produttore;
        private string modello;
        private string codiceSegreto;

        public Cassaforte(int numMatricola, string produttore, string modello, string codiceSegreto)
        {
            this.numMatricola = numMatricola;
            this.produttore = produttore;
            this.modello = modello;
            this.codiceSegreto = codiceSegreto;
        }

        public int NumMatricola { get { return numMatricola; } }
        public string Produttore { get {  return produttore; } }
        public string Modello { get {  return modello; } }  
        public string CodiceSegreto { get {  return codiceSegreto; } }


        public void Imposta(string codiceUtente, string n)
        {
            if (codiceUtente.Length > 5) return;
                codiceUtente = n;   
        }

        public void Apri()
        {

        }

        public void Chiudi(bool stato)
        {
            stato = false;
        }
    }


}
