using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSim.Parts
{
    public abstract class Substitutor
    {
        protected LetterMapping Mapping { get; private set; }

        public Substitutor(string encodedAlphabet)
        {
            Mapping = new LetterMapping();
            for (int i = 0; i < encodedAlphabet.Length; i++)
            {
                Mapping[i] = (int)Enum.Parse(typeof(Letter), encodedAlphabet[i].ToString());
            }
        }

        public abstract Letter ForwardSubstitute(Letter input);
        public abstract Letter BackwardSubstitute(Letter input);
    }
}
