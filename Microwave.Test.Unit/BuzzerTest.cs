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

        [Test]
        public void BurstBuzz_LegalInputParameters_1buzz()
        {
            uut.BurstBuzz(1);
            Assert.That(uut.LastBuzzAmount, Is.EqualTo(1));
        }

        [Test, Timeout(800)] //timeout to ensure that the buzzes dont take too long
        public void BurstBuzz_LegalInputParameters_3buzz()
        {
            uut.BurstBuzz(3);
            Assert.That(uut.LastBuzzAmount, Is.EqualTo(3));
        }

        [Test, Timeout(4500)] //timeout to ensure that the buzzes dont take too long
        public void BurstBuzz_LegalInputParameters_20buzz()
        {
            uut.BurstBuzz(20);
            Assert.That(uut.LastBuzzAmount, Is.EqualTo(20));
        }
    }
}