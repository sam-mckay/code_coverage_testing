using LibraryProjectCode;
using NUnit.Framework;

namespace LibraryProjectCodeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            SomeClass.SomeMethod();
            Assert.Pass();
        }
    }
}