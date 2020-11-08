using NUnit.Framework;
using NetCoreCICDApplication;
using System;

namespace NUnitTestProject1
{
    [TestFixture]
    public class Tests
    {
        private Person p;
        [SetUp]
        public void Setup ()
        {
            p = new Person{name="Anders",Age = 100};
        }

        [Test]
        public void Test1 ()
        {
            Assert.That(p.name == "Tom");

        }

        [Test]
        public void TestThatFail ()
        {
            Assert.That(p, Has.No.Property("Gender"));
        }

        [Test]
        [Description("Should throw argumentOutofRange when setting age too high.")]
        public void TestAgeException ()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                 () =>
                 {
                     p.Age = 101;
                 }
            );
        }
    }
}