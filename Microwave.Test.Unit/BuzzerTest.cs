using Microwave.Classes.Boundary;
using NUnit.Framework;

namespace Microwave.Test.Unit
{
    [TestFixture]
    public class BuzzerTest
    {
        private Buzzer uut;

        [SetUp]
        public void Setup()
        {
            uut = new Buzzer();
        }

        [TestCase(0)]
        [TestCase(21)]
        public void BurstBuzz_IllegalInputParameters(int times)
        {
            // We don't need an assert, as an exception would fail the test case
            Assert.Throws<System.ArgumentOutOfRangeException>(() => uut.BurstBuzz(times));

        }

        [TestCase(1)]
        [TestCase(20)]
        public void BurstBuzz_LegalInputParameters(int times)
        {

        }

    }
}