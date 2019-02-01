using NUnit.Framework;
using static NUnit.Framework.Assert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaSim.Parts;
using EnigmaSim;

namespace Tests
{
    [TestFixture]
    public class PartsTest
    {
        [TestCase(Letter.A, Letter.A, Letter.A, Letter.E)]
        [TestCase(Letter.B, Letter.A, Letter.A, Letter.J)]
        [TestCase(Letter.A, Letter.B, Letter.A, Letter.K)]
        [TestCase(Letter.Y, Letter.F, Letter.A, Letter.W)]
        public void TestRotor1(Letter pos, Letter ringSetting, Letter input, Letter output)
        {
            Rotor r1 = new Rotor1
            {
                Position = pos,
                RingSetting = ringSetting
            };
            AreEqual(output, r1.ForwardSubstitute(input));
            AreEqual(input, r1.BackwardSubstitute(output));
        }

        [TestCase(Letter.F, Letter.S)]
        public void TestReflectorB(Letter input, Letter output)
        {
            ReflectorB b = new ReflectorB();
            AreEqual(input, b.ForwardSubstitute(output));
            AreEqual(output, b.ForwardSubstitute(input));
        }
    }
}
