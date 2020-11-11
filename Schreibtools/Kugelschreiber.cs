using System;
using System.Collections.Generic;
using System.Text;

namespace Schreibtools
{
    class Kugelschreiber : Stift
    {
        public Kugelschreiber(int strichstärke) : base(strichstärke)
        {
            Typ = "Kugelschreiber";

        }

        public override string SchreibeText(string text)
        {
            string ausgabe = $"({Typ}, {Strichstärke}mm, {Farbe}) {text}";
            return ausgabe;
        }
    }
}

