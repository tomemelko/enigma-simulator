using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSim.Parts
{
    public abstract class Reflector : Substitutor
    {
        protected Reflector(string encodedAlphabet) : base(encodedAlphabet)
        {

        }

        public override Letter ForwardSubstitute(Letter input)
        {
            return Substitute(input);
        }

        public override Letter BackwardSubstitute(Letter input)
        {
            return Substitute(input);
        }

        private Letter Substitute(Letter input)
        {
            return (Letter)Mapping.Forward[(int)input];
        }
    }
}
