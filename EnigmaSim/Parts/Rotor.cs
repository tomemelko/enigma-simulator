using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSim.Parts
{
    public abstract class Rotor : Substitutor
    {
        public Letter Position
        {
            get => (Letter)position.Mod(26);
            set => position = (int)value;
        }
        public Letter RingSetting { get; set; }
        public abstract Letter RolloverPoint { get; }
        public bool ShouldRollover => Position == RolloverPoint;
        private int indexingOffset => Position - RingSetting;
        private int position;

        protected Rotor(string encodedAlphabet) : base(encodedAlphabet)
        {
        }

        public override Letter ForwardSubstitute(Letter input)
        {
            return (Letter)((Mapping.Forward[((int)(input + indexingOffset)).Mod(26)] - indexingOffset).Mod(26));
        }

        public override Letter BackwardSubstitute(Letter input)
        {
            return (Letter)((Mapping.Backward[((int)(input + indexingOffset)).Mod(26)] - indexingOffset).Mod(26));
        }
    }
}
