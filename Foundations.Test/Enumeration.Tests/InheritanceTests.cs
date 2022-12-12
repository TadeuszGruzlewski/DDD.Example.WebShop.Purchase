using System;
using DDD.Foundations;
using NUnit.Framework;

namespace EnumerationTests
{
    internal record class ExtendedStateEnum : StateEnum
    {
        public static readonly ExtendedStateEnum Cancelled = new(3, "Cancelled");
        public static readonly ExtendedStateEnum Failed = new(4, "Failed");

        public ExtendedStateEnum() { }
        private ExtendedStateEnum(int id, string name) : base(id, name) { }
    }

    public class InheritanceTests
    {
        [Test]
        public void Expected0()
        {
            //Assert
            Assert.AreEqual(StateEnum.NotStarted.Id, 0);
            Assert.AreEqual(StateEnum.NotStarted.Name, "Not Started");
        }

        [Test]
        public void Expected3()
        {
            //Assert
            Assert.AreEqual(ExtendedStateEnum.Cancelled.Id, 3);
            Assert.AreEqual(ExtendedStateEnum.Cancelled.Name, "Cancelled");
        }

        [Test]
        public void Expected4()
        {
            //Assert
            Assert.AreEqual(ExtendedStateEnum.Failed.Id, 4);
            Assert.AreEqual(ExtendedStateEnum.Failed.Name, "Failed");
        }

        [Test]
        public void Enumerator()
        {
            //Arrange
            var all = Enumeration.GetAll<ExtendedStateEnum>();
            var visited = new bool[5];

            //Act 
            foreach (var item in all)
                visited[item.Id] = true;

            //Assert
//            Assert.IsTrue(visited[0] & visited[1] & visited[2]);
            Assert.IsTrue(visited[3] & visited[4]);
        }

    }
}
