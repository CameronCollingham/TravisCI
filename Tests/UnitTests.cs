using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Subtract_Valid_Collingham()
        {
            Assert.AreEqual(3, Program.Subtract("4","1"));
            Assert.AreEqual(7, Program.Subtract("12", "5"));
            Assert.AreEqual(1, Program.Subtract("3", "2"));
        }

        [Test]
        public void Multiply_Valid_Collingham()
        {
            Assert.AreEqual(4, Program.Multiply("4", "1"));
            Assert.AreEqual(60, Program.Multiply("12", "5"));
            Assert.AreEqual(6, Program.Multiply("3", "2"));
        }

        [Test]
        public void Divide_Valid_Collingham()
        {
            Assert.AreEqual(4, Program.Divide("4", "1"));
            Assert.AreEqual(2, Program.Divide("10", "5"));
            Assert.AreEqual(2, Program.Divide("4", "2"));
        }

        [Test]
        public void Power_Valid_Collingham()
        {
            Assert.AreEqual(64, Program.Power("4", "3"));
            Assert.AreEqual(100, Program.Power("10", "2"));
            Assert.AreEqual(16, Program.Power("4", "2"));
        }

    }
}
