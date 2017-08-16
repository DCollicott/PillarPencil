using System;
using PillarPencil.Model;
using NUnit.Framework;

namespace PillarPencil.Test
{
    [TestFixture]
    [Category("Pencil_Erase")]
    public class Pencil_Erase
    {
        [Test]
        public void Pencil_Erase_Short_Text()
        {
            var pncl = new Pencil(1000, 10, 50);
            var ppr = new Paper();

            pncl.Write(ppr, "The quick brown fox jumped over the lazy dog");
            Assert.That(pncl.Erase(ppr, "v"), Is.EqualTo(true));
            Assert.That(ppr.Text, Is.EqualTo("The quick brown fox jumped o er the lazy dog"));
        }


        [Test]
        public void Pencil_Erase_Long_Text()
        {
            var pncl = new Pencil(10000, 10, 10000);
            var ppr = new Paper();

            pncl.Write(ppr, LorumIpsum.Text);
            Assert.That(pncl.Erase(ppr, LorumIpsum.MiddleChunk), Is.EqualTo(true));
            Assert.That(ppr.Text, Is.EqualTo(LorumIpsum.Text.Replace(LorumIpsum.MiddleChunk, new string(' ', LorumIpsum.MiddleChunk.Length))));
        }


        [Test]
        public void Pencil_Erase_Complete_Text()
        {
            var pncl = new Pencil(10000, 10, 10000);
            var ppr = new Paper();

            pncl.Write(ppr, LorumIpsum.Text);
            Assert.That(pncl.Erase(ppr, LorumIpsum.Text), Is.EqualTo(true));
            Assert.That(ppr.Text, Is.EqualTo(new string(' ', LorumIpsum.Text.Length)));
        }


        [Test]
        public void Pencil_Erase_Empty_Text()
        {
            var pncl = new Pencil(1000, 10, 50);
            var ppr = new Paper();

            pncl.Write(ppr, "The quick brown fox jumped over the lazy dog");
            Assert.That(pncl.Erase(ppr, ""), Is.EqualTo(true));
            Assert.That(ppr.Text, Is.EqualTo("The quick brown fox jumped over the lazy dog"));
        }


        [Test]
        public void Pencil_Erase_Null_Text()
        {
            var pncl = new Pencil(1000, 10, 50);
            var ppr = new Paper();

            pncl.Write(ppr, "The quick brown fox jumped over the lazy dog");
            Assert.That(pncl.Erase(ppr, null), Is.EqualTo(true));
            Assert.That(ppr.Text, Is.EqualTo("The quick brown fox jumped over the lazy dog"));
        }


        [Test]
        public void Pencil_Erase_Empty_Paper_Does_Nothing()
        {
            var pncl = new Pencil(1000, 10, 50);
            var ppr = new Paper();

            Assert.That(pncl.Erase(ppr, "zap"), Is.EqualTo(false));
            Assert.That(ppr.Text, Is.EqualTo(""));
        }


        [Test]
        public void Pencil_Erase_Short_Text_Degrades_Eraser()
        {
            var pncl = new Pencil(1000, 10, 50);
            var ppr = new Paper();

            pncl.Write(ppr, "The quick brown fox jumped over the lazy dog");
            Assert.That(pncl.Erase(ppr, "v"), Is.EqualTo(true));
            Assert.That(pncl.EraserLength, Is.EqualTo(49));
        }


        [Test]
        public void Pencil_Erase_Long_Text_Degrades_Eraser()
        {
            var pncl = new Pencil(10000, 10, 10000);
            var ppr = new Paper();

            pncl.Write(ppr, new string('a', 9000));
            Assert.That(pncl.Erase(ppr, new string('a', 8500)), Is.EqualTo(true));
            Assert.That(pncl.EraserLength, Is.EqualTo(1500));
        }


        [Test]
        public void Pencil_Erase_White_Space_Doesnt_Degrade_Eraser()
        {
            var pncl = new Pencil(1000, 10, 50);
            var ppr = new Paper();

            pncl.Write(ppr, "The quick brown fox jumped over the lazy dog");
            Assert.That(pncl.Erase(ppr, "fox jumped over"), Is.EqualTo(true));
            Assert.That(pncl.EraserLength, Is.EqualTo(37));
        }
    }
}
