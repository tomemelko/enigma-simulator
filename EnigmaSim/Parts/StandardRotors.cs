using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSim.Parts
{
    public class Rotor1 : Rotor
    {
        public override Letter RolloverPoint => Letter.Q;
        public Rotor1() : base("EKMFLGDQVZNTOWYHXUSPAIBRCJ")
        {
        }
    }

    public class Rotor2 : Rotor
    {
        public override Letter RolloverPoint => Letter.E;
        public Rotor2() : base("AJDKSIRUXBLHWTMCQGZNPYFVOE")
        {
        }
    }

    public class Rotor3 : Rotor
    {
        public override Letter RolloverPoint => Letter.V;
        public Rotor3() : base("BDFHJLCPRTXVZNYEIWGAKMUSQO")
        {
        }
    }
}
