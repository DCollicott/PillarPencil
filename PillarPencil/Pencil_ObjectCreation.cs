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
            var pncl = new Pencil(10000);

            // Not much of a test. but it will be soon.
            Assert.That(pncl, !Is.Null);
            Assert.That(pncl.Durability, Is.EqualTo(10000));
        }


        [Test]
        public void Pencil_Create_Object_Zero_Durability()
        {
            var pncl = new Pencil(0);

            // Not much of a test. but it will be soon.
            Assert.That(pncl.Durability, Is.EqualTo(0));
        }


        [Test]
        public void Pencil_Create_Object_Invalid_Durability()
        {
            try
            {
                var pncl = new Pencil(-1);
                Assert.Fail("Pencil constructor allowed invalid Duration value.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }
        }
    }
}
