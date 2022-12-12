using System;
using NUnit.Framework;

namespace PositionalRecordTests
{
    internal record Foo11(int Bar)
    {
        public int Bar => 20;
        public int Baz = Bar;
        public int BaZ => Bar;
    }

    internal record Foo12(int Bar)
    {
        public int Bar = Bar;
        public int Baz = Bar;
        public int BaZ => Bar;
    }

    //internal record Foo2(int Bar)
    //{
    //    public int Bar = Bar;
    //    public int Baz = Bar;
    //    public int BaZ => Bar;

    //    //        public int Bar => Bar;    infinite loop ?
    //    //        public int Bar = Bar;
    //}

    public class PeculiarPositionalRecordTests
    {
        [Test]
        public void Peculiar11()
        {
            //Arrange
            Foo11 f;

            //Act
            f = new(10);

            //Assert
            Assert.AreEqual(f.Bar, 20);
            Assert.AreEqual(f.Baz, 10);
            Assert.AreEqual(f.BaZ, 20);
        }

        [Test]
        public void Peculiar12()
        {
            //Arrange
            Foo12 f;

            //Act
            f = new(10);

            //Assert
            Assert.AreEqual(f.Bar, 10);
            Assert.AreEqual(f.Baz, 10);
            Assert.AreEqual(f.BaZ, 10);
        }

        //[Test]
        //public void Peculiar4()
        //{
        //    //Arrange
        //    Foo4 f;

        //    //Act
        //    f = new(10);

        //    //Assert
        //    Assert.AreEqual(f.Bar, 10);
        //    Assert.AreEqual(f.Baz, 10);
        //    Assert.AreEqual(f.BaZ, 10);
        //}

    }
}
