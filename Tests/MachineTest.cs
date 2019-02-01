using EnigmaSim;
using static NUnit.Framework.Assert;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    class MachineTest
    {
        [TestCase(Letter.A, Letter.B)]
        public void TestOneLetter(Letter i, Letter o)
        {
            Machine machine = new Machine();
            AreEqual(o, machine.EncodeLetter(i));
        }

        [TestCase("AAAAA", "BDZGO")]
        // Test single rollover
        [TestCase("AAAAAAAAAAAAAAAAAAAAAAAAAA", "BDZGOWCXLTKSBTMCDLPBMUQOFX")]
        // Test double move
        [TestCase("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "BDZGOWCXLTKSBTMCDLPBMUQOFXYHCXTGYJFLINHNXSHIUNTHEORXPQPKOVHCBUBTZSZSOOSTGOTFSODBBZZLXLCYZXIFGWFDZEEQIBMGFJBWZFCKPFMGBXQCIVIBBRNCOCJUVYDKMVJPFMDRMTGLWFOZL")]
        [TestCase("THISISAVERYSECRETMESSAGE", "OPGNDXCHWXZALOGNEDOTKUYZ")]
        public void TestString(string i, string o)
        {
            Machine machine = new Machine();
            AreEqual(o, machine.EncodeString(i));
        }
    }
}
