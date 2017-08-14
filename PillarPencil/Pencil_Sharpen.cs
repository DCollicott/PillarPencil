using System;
using PillarPencil.Model;
using NUnit.Framework;


namespace PillarPencil.Test
{
    [TestFixture]
    [Category("Pencil_Sharpen")]
    public class Pencil_Sharpen
    {
        [Test]
        public void Pencil_Sharpen_Resets_Durability()
        {
            var pncl = new Pencil(10000, 5, 50);
            var ppr = new Paper();

            pncl.Write(ppr, "a");

            Assert.That(pncl.Durability, Is.EqualTo(9999));

            Assert.That(pncl.Sharpen(), Is.EqualTo(true));
            Assert.That(pncl.Durability, Is.EqualTo(10000));
        }


        [Test]
        public void Pencil_Sharpen_Decreases_Length()
        {
            var pncl = new Pencil(10000, 5, 50);
            var ppr = new Paper();

            pncl.Write(ppr, "a");
            pncl.Sharpen();

            Assert.That(pncl.Length, Is.EqualTo(4));
        }


        [Test]
        public void Pencil_Sharpen_Zero_Length_No_Durability_Effect()
        {
            var pncl = new Pencil(10000, 0, 50);
            var ppr = new Paper();

            Assert.That(pncl.Sharpen(), Is.EqualTo(false));
            Assert.That(pncl.Durability, Is.EqualTo(10000));
            Assert.That(pncl.Length, Is.EqualTo(0));
        }


        [Test]
        public void Pencil_Sharpen_Full_Durability_No_Length_Durability_Effect()
        {
            var pncl = new Pencil(10000, 5, 50);
            var ppr = new Paper();

            Assert.That(pncl.Sharpen(), Is.EqualTo(true));
            Assert.That(pncl.Durability, Is.EqualTo(10000));
        }
    }
}
