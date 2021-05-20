using NUnit.Framework;

namespace CodeCoverageTesting.UnitTests
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
            BasicFeature.Method1();
            Assert.Pass();
        }
        
        [Test]
        public void Test2()
        {
            BasicFeature.Method2();
            Assert.Pass();
        }
        
        [Test]
        public void Test3()
        {
            BasicFeature.Method1();
            Assert.Pass();
        }
        
    }
}