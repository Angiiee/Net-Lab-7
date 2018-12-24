using Lab7.entity;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        Tram tram;

        [SetUp]
        public void Setup()
        {
            tram = new Tram(6, " ..Chuh Chuh Chuh ");
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("Public Transport. I'm a Tram and my number is 6. I do Chuh Chuh Chuh And I'm awesome!", tram.GetInfo());
        }
    }
}