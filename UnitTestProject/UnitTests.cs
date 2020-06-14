using Microsoft.VisualStudio.TestTools.UnitTesting;
using static PracticeTask3.Program;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod01()
        {
            double x = 0;
            double y = 0;
            bool answer = IsOwned(x, y);
            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void TestMethod02()
        {
            double x = 1;
            double y = 1;
            bool answer = IsOwned(x, y);
            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void TestMethod03()
        {
            double x = 1;
            double y = -2;
            bool answer = IsOwned(x, y);
            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void TestMethod04()
        {
            double x = -1;
            double y = -2;
            bool answer = IsOwned(x, y);
            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void TestMethod05()
        {
            double x = -1;
            double y = 1;
            bool answer = IsOwned(x, y);
            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void TestMethod06()
        {
            double x = 0.6;
            double y = 0.5;
            bool answer = IsOwned(x, y);
            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void TestMethod07()
        {
            double x = 0.5;
            double y = -1;
            bool answer = IsOwned(x, y);
            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void TestMethod08()
        {
            double x = -0.5;
            double y = -1;
            bool answer = IsOwned(x, y);
            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void TestMethod09()
        {
            double x = -0.6;
            double y = 0.5;
            bool answer = IsOwned(x, y);
            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void TestMethod10()
        {
            double x = 0.4;
            double y = 0.5;
            bool answer = IsOwned(x, y);
            Assert.AreEqual(false, answer);
        }

        [TestMethod]
        public void TestMethod11()
        {
            double x = -0.3;
            double y = 0.5;
            bool answer = IsOwned(x, y);
            Assert.AreEqual(false, answer);
        }

        [TestMethod]
        public void TestMethod12()
        {
            double x = 0;
            double y = 1;
            bool answer = IsOwned(x, y);
            Assert.AreEqual(false, answer);
        }

        [TestMethod]
        public void TestMethod13()
        {
            double x = 2;
            double y = 0;
            bool answer = IsOwned(x, y);
            Assert.AreEqual(false, answer);
        }

        [TestMethod]
        public void TestMethod14()
        {
            double x = 0;
            double y = -3;
            bool answer = IsOwned(x, y);
            Assert.AreEqual(false, answer);
        }

        [TestMethod]
        public void TestMethod15()
        {
            double x = -2;
            double y = 0;
            bool answer = IsOwned(x, y);
            Assert.AreEqual(false, answer);
        }
    }
}