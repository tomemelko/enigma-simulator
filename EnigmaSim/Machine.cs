using EnigmaSim.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSim
{
    public class Machine
    {
        private Reflector reflector;
        private Rotor left;
        private Rotor middle;
        private Rotor right;
        
        public Machine(Reflector reflector, Rotor left, Rotor middle, Rotor right)
        {
            this.reflector = reflector;
            this.left = left;
            this.middle = middle;
            this.right = right;
        }

        public Machine() : this(new ReflectorB(), new Rotor1(), new Rotor2(), new Rotor3())
        {

        }

        public string EncodeString(string inString)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in inString)
            {
                sb.Append(this.EncodeLetter((Letter)Enum.Parse(typeof(Letter), c.ToString())));
            }

            return sb.ToString();
        }

        public Letter EncodeLetter(Letter i)
        {
            if (middle.ShouldRollover)
            {
                left.Position++;
            }
            if (right.ShouldRollover || (middle.ShouldRollover && right.Position == right.RolloverPoint + 1))
            {
                middle.Position++;
            }
            
            right.Position++;

            List<Func<Letter, Letter>> ops = new List<Func<Letter, Letter>>
            {
                right.ForwardSubstitute,
                middle.ForwardSubstitute,
                left.ForwardSubstitute,
                reflector.ForwardSubstitute,
                left.BackwardSubstitute,
                middle.BackwardSubstitute,
                right.BackwardSubstitute
            };

            Letter result = i;
            for (int j = 0; j < ops.Count; j++)
            {
                result = ops[j](result);
            }
            return result;
        }
    }
}
