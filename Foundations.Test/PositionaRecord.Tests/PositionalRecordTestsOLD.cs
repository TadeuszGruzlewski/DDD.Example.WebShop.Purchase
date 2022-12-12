//using System;
//using NUnit.Framework;

//namespace PositionalRecordTests
//{
//    internal record Foo(int Bar)
//    {
//        public int Baz = Bar;
//        public int BaZ => Bar;
//    }
//    internal record Foo1(int Bar)
//    {
//        public int Bar => 41;
//        public int Baz = Bar;
//    }

//    internal record Foo3(int Bar)
//    {
//        public int Bar => 41;
//        public int Baz = Bar;
//        public int BaZ => Bar;

//        //        public int Bar => Bar;    infinite loop ?
//        //        public int Bar = Bar;
//    }

//    public class PositionalRecordTests
//    {
//        [Test]
//        public void Peculiar1()
//        {
//            //Arrange
//            Foo1 f;

//            //Act
//            f = new(42);

//            //Assert
//            Assert.AreEqual(f.Bar, 41);
//            Assert.AreEqual(f.Baz, 42);
//        }

//        [Test]
//        public void Peculiar3()
//        {
//            //Arrange
//            Foo1 f;

//            //Act
//            f = new(42);

//            //Assert
//            Assert.AreEqual(f.Bar, 41);
//            Assert.AreEqual(f.Baz, 42);
//        }

//    }
//}
