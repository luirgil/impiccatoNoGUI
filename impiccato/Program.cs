using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.IO;


namespace GiocoDellImpiccato
{
    
    class Program
    {
        public static void Main()
        {
            funzioniGiocoImpiccato funzioni = new funzioniGiocoImpiccato();
            string parolaSegreta = "", parolaVisualizzata = "";
            char carattere;
            int tentativi = 6;
            string[] partiDelCorpo = new string[0];
            partiDelCorpo = funzioni.InizializzaPartiDelCorpo(partiDelCorpo);

            int indicePartiDelCorpo = 0;


            
            parolaSegreta = funzioni.PescaParola(parolaSegreta);

            parolaVisualizzata = funzioni.InizializzaParolaVisualizzata(parolaVisualizzata, parolaSegreta);

            while ((tentativi > 0) && parolaVisualizzata.Contains('_'))
            {

                funzioni.PrintWithString("la parola da indovinare è ",parolaVisualizzata);

                Console.Write("Scegliere una lettera: ");
                carattere = Console.ReadLine().FirstOrDefault();

                if (funzioni.RimozioneCarattere(parolaSegreta, carattere))
                {
                    for (int i = 0; i < parolaSegreta.Length; i++)
                    {
                        if (parolaSegreta[i] == carattere)
                        {
                            parolaVisualizzata = parolaVisualizzata.Remove(i, 1).Insert(i, carattere.ToString());
                        }
                    }
                }
                else
                {
                    funzioni.StampaPartiDelCorpo(partiDelCorpo, indicePartiDelCorpo);
                    indicePartiDelCorpo++;
                    tentativi--;
                }
            }

            Console.WriteLine(funzioni.StampaRisultatoSe("Bravo! Hai indovinato la parola: ", "Mi dispiace, sei stato impiccato!", tentativi, parolaSegreta));
        }
    }
}