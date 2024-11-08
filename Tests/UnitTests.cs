using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_ValidRaatz()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_InvalidRaatz()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_NullRaatz()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Subtract_ValidRaatz()
        {
            Assert.AreEqual(2, Program.Subtract("5", "3"));
            Assert.AreEqual(0, Program.Subtract("2", "2"));
            Assert.AreEqual(-4, Program.Subtract("3", "7"));
        }

        [Test]
        public void Subtract_InvalidRaatz()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("5", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "3"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_NullRaatz()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("5", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "3"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        // Tests for Multiply
        [Test]
        public void Multiply_ValidRaatz()
        {
            Assert.AreEqual(12, Program.Multiply("5", "3"));
            Assert.AreEqual(0, Program.Multiply("0", "3"));
            Assert.AreEqual(6, Program.Multiply("2", "3"));
        }

        [Test]
        public void Multiply_InvalidRaatz()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("5", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "3"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_NullRaatz()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("5", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "3"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        // Tests for Divide
        [Test]
        public void Divide_ValidRaatz()
        {
            Assert.AreEqual(2, Program.Divide("6", "3"));
            Assert.AreEqual(5, Program.Divide("10", "2"));
            Assert.AreEqual(1, Program.Divide("3", "3"));
        }

        [Test]
        public void Divide_InvalidRaatz()
        {
            Assert.Throws<FormatException>(() => Program.Divide("6", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "3"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_NullRaatz()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("6", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "3"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Divide_ByZeroRaatz()
        {
            Assert.Throws<DivideByZeroException>(() => Program.Divide("6", "0"));
        }

        // Tests for Power
        [Test]
        public void Power_ValidRaatz()
        {
            Assert.AreEqual(8, Program.Power("2", "3"));
            Assert.AreEqual(1, Program.Power("5", "0"));
            Assert.AreEqual(0.25, Program.Power("2", "-2"));
        }

        [Test]
        public void Power_InvalidRaatz()
        {
            Assert.Throws<FormatException>(() => Program.Power("2", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "3"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }

        [Test]
        public void Power_NullRaatz()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("2", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "3"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}    
