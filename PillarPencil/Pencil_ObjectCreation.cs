using System;
using PillarPencil.Model;
using NUnit.Framework;


namespace PillarPencil.Test
{
    [TestFixture]
    [Category("Pencil_Object")]
    public class Pencil_ObjectCreation
    {
        [Test]
        public void Pencil_Create_Object()
        {
            var pncl = new Pencil(10000, 5, 50);

            Assert.That(pncl, !Is.Null);
            Assert.That(pncl.Durability, Is.EqualTo(10000));
        }


        [Test]
        public void Pencil_Create_Object_Zero_Durability()
        {
            var pncl = new Pencil(0, 5, 50);

            Assert.That(pncl.Durability, Is.EqualTo(0));
        }


        [Test]
        public void Pencil_Create_Object_Invalid_Durability()
        {
            try
            {
                var pncl = new Pencil(-1, 5, 50);
                Assert.Fail("Pencil constructor allowed invalid Duration value.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }
        }


        [Test]
        public void Pencil_Create_Object_Zero_Length()
        {
            var pncl = new Pencil(10000, 0, 50);

            Assert.That(pncl.Length, Is.EqualTo(0));
        }


        [Test]
        public void Pencil_Create_Object_Invalid_Length()
        {
            try
            {
                var pncl = new Pencil(10000, -1, 50);
                Assert.Fail("Pencil constructor allowed invalid Length value.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }
        }
    }
}
