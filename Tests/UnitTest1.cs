using NUnit.Framework;
using notile.cs;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var bang = new Class1();
            System.Console.WriteLine(bang);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}