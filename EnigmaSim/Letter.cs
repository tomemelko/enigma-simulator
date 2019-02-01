using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSim
{
    public enum Letter
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
        I,
        J,
        K,
        L,
        M,
        N,
        O,
        P,
        Q,
        R,
        S,
        T,
        U,
        V,
        W,
        X,
        Y,
        Z
    }

    public class LetterMapping
    {
        public Dictionary<int, int> Forward { get; }
        public Dictionary<int, int> Backward { get; }

        public LetterMapping()
        {
            Forward = new Dictionary<int, int>();
            Backward = new Dictionary<int, int>();
        }

        public int this[int i]
        {
            set
            {
                Forward[i] = value;
                Backward[value] = i;
            }
        }
    }
}
