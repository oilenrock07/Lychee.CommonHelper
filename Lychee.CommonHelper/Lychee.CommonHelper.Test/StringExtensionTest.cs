using Lychee.CommonHelper.Extensions;
using NUnit.Framework;

namespace Lychee.CommonHelper.Test
{
    [TestFixture]
    public class StringExtensionTest
    {
        [Test]
        [TestCase("Cornelio Cawicaan", true)]
        [TestCase("CorNelio Cawicaan", true)]
        [TestCase("Cornelio Cawicaa", false)]
        public void CanCompareStringWithoutComparison(string str, bool match)
        {
            Assert.That("Cornelio Cawicaan".EqualsTo(str), Is.EqualTo(match));
        }

        [Test]
        [TestCase("Cornelio Cawicaan", true)]
        [TestCase("CorNelio Cawicaan", true)]
        [TestCase("Cornelio Cawicaa", false)]
        public void CanCompareStringWithComparison(string str, bool match)
        {
            Assert.That("Cornelio Cawicaan".EqualsTo(str), Is.EqualTo(match));
        }
    }
}

