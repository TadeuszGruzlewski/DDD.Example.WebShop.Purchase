using System;
using NUnit.Framework;

namespace PositionalRecordTests
{
    internal record Foo(int Bar);

    internal record Foo1(int Bar)
    {
        public int Bar = Bar;
    }

    internal record Foo2(int Bar)
    {
        public int Baz = Bar;
        public int BaZ => Bar;
    }

    public class ExpectedPositionalRecordTests
    {
        [Test]
        public void Expected()
        {
            //Arrange
            Foo f;

            //Act
            f = new(10);

            //Assert
            Assert.AreEqual(f.Bar, 10);
        }

        [Test]
        public void Expected1()
        {
            //Arrange
            Foo1 f;

            //Act
            f = new(10);

            //Assert
            Assert.AreEqual(f.Bar, 10);
        }

        [Test]
        public void Expected2()
        {
            //Arrange
            Foo2 f;

            //Act
            f = new(10);

            //Assert
            Assert.AreEqual(f.Bar, 10);
            Assert.AreEqual(f.Baz, 10);
            Assert.AreEqual(f.BaZ, 10);
        }

    }
}
