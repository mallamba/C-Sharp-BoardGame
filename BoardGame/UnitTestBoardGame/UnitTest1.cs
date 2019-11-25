using System;
using BoardGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBoardGame
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSetSize()
        {
            RectangleBoard rb = new RectangleBoard();
            rb.SetSize(4,4);
            Assert.AreEqual(4, rb.xLength);
            Assert.AreEqual(4, rb.yLength);
        }

        [TestMethod]
        public void TestSetPosision()
        {
            RectangleBoard rb = new RectangleBoard();
            rb.SetPosition(2, 2);
            Assert.AreEqual(2, rb.x);
            Assert.AreEqual(2, rb.y);
        }

        
        [TestMethod]
        public void TestRotateClockwise()
        {
            RectangleBoard rb = new RectangleBoard();
            rb.RotateClockwise();
            Assert.AreEqual(2, rb.direction);
        }

        [TestMethod]
        public void TestRotateCounterClockwise()
        {
            RectangleBoard rb = new RectangleBoard();
            rb.RotateCounterClockwise();
            Assert.AreEqual(3, rb.direction);
        }


        [TestMethod]
        public void TestIsOutside()
        {
            RectangleBoard rb = new RectangleBoard();
            rb.SetSize(4, 4);
            rb.SetPosition(-1, 2);
            Assert.AreEqual(true, rb.IsOutside());
        }


        [TestMethod]
        public void TestMove()
        {
            RectangleBoard rb = new RectangleBoard();
            rb.SetSize(4, 4);
            rb.SetPosition(2, 2);
            rb.Move(1);
            Assert.AreEqual(2, rb.x);
            Assert.AreEqual(1, rb.y);
        }


        [TestMethod]
        public void TestDoCommand()
        {
            RectangleBoard rb = new RectangleBoard();
            rb.SetSize(4, 4);
            rb.SetPosition(2, 2);
            rb.DoCommand(3);
            Assert.AreEqual(2, rb.direction);
        }
    }
}
