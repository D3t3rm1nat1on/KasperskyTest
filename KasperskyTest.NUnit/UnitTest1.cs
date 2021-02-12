using NUnit.Framework;

namespace KasperskyTest.NUnit
{
    public class Tests
    {
        private FileProcessor _processor;
        
        [SetUp]
        public void Setup()
        {
            _processor = new FileProcessor();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}