using System;
using PillarPencil.Model;
using NUnit.Framework;

namespace PillarPencil.Test
{
    [TestFixture]
    [Category("Paper_Manipulation")]
    public class Paper_Manipulation
    {
        [Test]
        public void Paper_Append()
        {
            var ppr = new Paper();

            ppr.Append("Hello");
        }



        [Test]
        public void Paper_Append_Short_Text()
        {
            var ppr = new Paper();

            ppr.Append("Z");

            Assert.That(ppr.Text(), Is.EqualTo("Z"));
        }


        [Test]
        public void Paper_Append_Long_Text()
        {
            var ppr = new Paper();

            ppr.Append(LorumIpsum.Text);

            Assert.That(ppr.Text(), Is.EqualTo(LorumIpsum.Text));
        }


        [Test]
        public void Paper_Append_Empty_Text()
        {
            var ppr = new Paper();

            ppr.Append("");

            Assert.That(ppr.Text(), Is.EqualTo(""));
        }


        [Test]
        public void Paper_Append_Null_Text()
        {
            var ppr = new Paper();

            ppr.Append(null);

            Assert.That(ppr.Text(), Is.EqualTo(""));
        }
    }
}
