﻿using System;
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
            var pncl = new Pencil();

            // Not much of a test. but it will be soon.
            Assert.That(pncl, !Is.Null);
        }
    }
}
