using System;
using System.Collections.Generic;
using System.Text;

namespace Schreibtools
{
    class Program
    {
        static void Main(string[] args)
        {
            Buntstift b1 = new Buntstift(3, ConsoleColor.Green);
            Buntstift b2 = new Buntstift(4, ConsoleColor.Blue);

            Kugelschreiber k1 = new Kugelschreiber(5);
            Kugelschreiber k2 = new Kugelschreiber(5);

            List<Stift> liste = new List<Stift>();
            liste.Add(k1);
            liste.Add(k2);
            liste.Add(b1);
            liste.Add(b2);


            


            /*
             string RandomString(long Length)
            {
                System.Random rnd = new System.Random();
                StringBuilder Temp = new StringBuilder();
                for (Int64 i = 0; i < Length; i++)
                {
                    Temp.Append(Convert.ToChar(((byte)rnd.Next(254))).ToString());
                }
                return Temp.ToString();
            }
            */

            foreach (var item in liste)
            {
                /*
                string wörter;
                for (int i = 0; i < 6; i++)
                {
                    Random random = new Random();
                    int zahl = random.Next(0, 5);
                    wörter = wordlist[zahl] + " ";
                }
                */
                Console.ForegroundColor = item.Farbe;
                Console.WriteLine($"(Typ: {item.Typ} | Strichstärke: {item.Strichstärke} | Farbe: {item.Farbe}) | Text: {generieren(5)}");




               
            }
        }
        public static string generieren(int anzahl)
        {
            string wörter = "";
            string[] wordlist = new string[] { "Baum", "Herbst", "Blätter", "Schnee", "Kürbis" };
            for (int i = 0; i < anzahl; i++)
            {
                Random random = new Random();
                int zahl = random.Next(0, 5);
                wörter += wordlist[zahl] + " ";
            }
            return wörter;
        }

    }
}
