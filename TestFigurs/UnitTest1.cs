using FigursLibrary;
using NUnit.Framework;

namespace TestFigurs
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSqureCircle()
        {
            var S = new Circle { R = 3 }.GetSquare();
            Assert.That(S,Is.EqualTo(28.27));
        }
        [Test]
        public void TestNotTriagle()
        {
            var S = new Triagle { A = 1, B=4, C= 2 }.GetSquare();
            Assert.That(S, Is.EqualTo(0));
        }
        [Test]
        public void TestSqureTriagle()
        {
            var S = new Triagle { A = 5, B = 6, C = 3 }.GetSquare();
            Assert.That(S, Is.EqualTo(7.48));
        }
        [Test]
        public void TestIsRegtangularTriagle()
        {
           
            Assert.That(new Triagle { A = 3, B = 4, C = 5 }.IsRegtangular(), Is.EqualTo(true));
        }
    }
}