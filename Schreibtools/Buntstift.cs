using System;
using System.Collections.Generic;
using System.Text;

namespace Schreibtools
{
    class Buntstift : Stift
    {
        public Buntstift(int strichstärke, ConsoleColor farbe) : base(strichstärke)
        {
            Farbe = farbe;
            Typ = "Buntstift";
          
        }

        public override string SchreibeText(string text)
        {
            string ausgabe = $"({Typ}, {Strichstärke}, {Farbe}) {text}";
            return ausgabe;
        }
    }

}
