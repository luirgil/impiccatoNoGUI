using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.IO;
using System.Diagnostics.Tracing;

public class funzioniGiocoImpiccato
{
    Random rnd = new Random();
    public string PescaParola(string Parola)
    {
        int indiceParola;
        string[] lines = File.ReadAllLines("words.txt");
        indiceParola = rnd.Next(0, lines.Length);
        Parola = lines[indiceParola];
        return Parola;
    }
    public string[] InizializzaPartiDelCorpo(string[] restituzione)
    {
        string[] disegno = {
                " O \n",
                " O \n/  \n",
                " O \n/| \n",
                " O \n/|\\\n",
                " O \n/|\\\n/\n ",
                " O \n/|\\\n/ \\\n" };

        restituzione = disegno;
        return restituzione;
    }

    public string InizializzaParolaSegreta(string restituzione)
    {
        Console.Write("inserisci la parola segreta ");
        return restituzione = Console.ReadLine();
    }
    public void PrintWithString(string msg, string value) 
    {
        Console.WriteLine(msg + value);
    }
    public char SelectCharacter(string msg,char carattere)
    {
        Console.Write(msg);
        carattere = Console.ReadLine().FirstOrDefault();
        return carattere;
    }

    public string InizializzaParolaVisualizzata(string restituzione, string lunghezza)
    {
        return restituzione = new string('_', lunghezza.Length);
    }


    public bool RimozioneCarattere(string parolaSegreta, char lettera)
    {
        bool letteraTrovata = false;
        for (int i = 0; i < parolaSegreta.Length; i++)
        {
            if (parolaSegreta[i] == lettera)
            {
                letteraTrovata = true;
            }
        }
        return letteraTrovata;
    }

    public void StampaPartiDelCorpo(string[] omino, int i)
    {
        Console.WriteLine(); //andata a capo
        Console.WriteLine(omino[i]);
    }

    public string StampaRisultatoSe(string risultatoSi, string risultatoNo,int controlloNo, string parola) 
    {
        if(controlloNo == 0)
        {
            return risultatoNo;
        }
        else
        return risultatoSi + parola;
    }
}