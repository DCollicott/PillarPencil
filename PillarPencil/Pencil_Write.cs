using System;
using PillarPencil.Model;
using NUnit.Framework;


namespace PillarPencil.Test
{
    [TestFixture]
    [Category("Pencil_Write")]
    public class Pencil_Write
    {
        [Test]
        public void Pencil_Write_Text()
        {
            var pncl = new Pencil();
            var ppr = new Paper();

            pncl.Write(ppr, "The quick brown fox jumps over the lazy dog.");

            Assert.That(ppr.Text, Is.EqualTo("The quick brown fox jumps over the lazy dog."));
        }


        [Test]
        public void Pencil_Write_Short_Text()
        {
            throw new NotImplementedException();
        }


        [Test]
        public void Pencil_Write_Long_Text()
        {
            throw new NotImplementedException();
        }


        [Test]
        public void Pencil_Write_Empty_Text()
        {
            throw new NotImplementedException();
        }


        [Test]
        public void Pencil_Write_Null_Text()
        {
            throw new NotImplementedException();
        }
    }
}
