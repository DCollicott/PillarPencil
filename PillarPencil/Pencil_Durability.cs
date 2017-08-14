using System;
using PillarPencil.Model;
using NUnit.Framework;


namespace PillarPencil.Test
{
    [TestFixture]
    [Category("Pencil_Durability")]
    public class Pencil_Durability
    {
        [Test]
        public void Pencil_Write_LowerCase_Reduces_Durability()
        {
            var pncl = new Pencil(10000);
            var ppr = new Paper();

            pncl.Write(ppr, "a");

            Assert.That(pncl.Durability, Is.EqualTo(9999));
        }


        [Test]
        public void Pencil_Write_UpperCase_Reduces_Durability()
        {
            var pncl = new Pencil(10000);
            var ppr = new Paper();

            pncl.Write(ppr, "A");

            Assert.That(pncl.Durability, Is.EqualTo(9998));
        }


        [Test]
        public void Pencil_Write_WhiteSpace_Doesnt_Reduce_Durability()
        {
            var pncl = new Pencil(10000);
            var ppr = new Paper();

            pncl.Write(ppr, " ");

            Assert.That(pncl.Durability, Is.EqualTo(10000));
        }


        [Test]
        public void Pencil_Write_Newline_Doesnt_Reduce_Durability()
        {
            var pncl = new Pencil(10000);
            var ppr = new Paper();

            pncl.Write(ppr, Environment.NewLine);

            Assert.That(pncl.Durability, Is.EqualTo(10000));
        }


        [Test]
        public void Pencil_Write_Partial_With_Insufficient_Durability()
        {
            throw new NotImplementedException();
        }


        [Test]
        public void Pencil_Cant_Write_With_Zero_Durability()
        {
            throw new NotImplementedException();
        }


        [Test]
        public void Pencil_Sharpen_Resets_Durability()
        {
            throw new NotImplementedException();
        }
    }
}
