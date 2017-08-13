using System;
using PillarPencil.Model;
using NUnit.Framework;

namespace PillarPencil.Test
{
    [TestFixture]
    [Category("Paper_Object")]
    public class Paper_ObjectCreation
    {
        [Test]
        public void Paper_Create_Object()
        {
            var ppr = new Paper();

            // Not much of a test. but it will be soon.
            Assert.That(ppr, !Is.Null);
        }
    }
}
