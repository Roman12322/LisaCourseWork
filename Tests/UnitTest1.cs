using NUnit.Framework;
using static Lisa.Shiphr;

namespace Tests
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
            EncDecRYPTOR BufferElement = new EncDecRYPTOR();
            var temp = BufferElement.Encypt("0","0","Привет, Медвед");
            Assert.AreEqual("",temp);
        }
        [Test]
        public void Test2()
        {
            EncDecRYPTOR BufferElement = new EncDecRYPTOR();
            var temp = BufferElement.Encypt("1", "0", "Привет, Медвед");
            Assert.AreEqual("", temp);
        }
        [Test]
        public void Test3()
        {
            EncDecRYPTOR BufferElement = new EncDecRYPTOR();
            var temp = BufferElement.Encypt("0", "1", "Привет, Медвед");
            Assert.AreEqual("", temp);
        }
        [Test]
        public void Test4()
        {
            EncDecRYPTOR BufferElement = new EncDecRYPTOR();
            var temp = BufferElement.Encypt("4", "4", "Привет, Медвед");
            Assert.AreEqual("в в и,д ртедПеМе", temp);
        }
        [Test]
        public void Test5()
        {
            EncDecRYPTOR BufferElement = new EncDecRYPTOR();
            var temp = BufferElement.Decrypt("0", "0", "в в и,д ртедПеМе");
            Assert.AreEqual("", temp);
        }
        [Test]
        public void Test6()
        {
            EncDecRYPTOR BufferElement = new EncDecRYPTOR();
            var temp = BufferElement.Decrypt("1", "0", "в в и,д ртедПеМе");
            Assert.AreEqual("", temp);
        }
        [Test]
        public void Test7()
        {
            EncDecRYPTOR BufferElement = new EncDecRYPTOR();
            var temp = BufferElement.Decrypt("0", "1", "в в и,д ртедПеМе");
            Assert.AreEqual("", temp);
        }
        [Test]
        public void Test8()
        {
            EncDecRYPTOR BufferElement = new EncDecRYPTOR();
            var temp = BufferElement.Decrypt("4", "4", "в в и,д ртедПеМе");
            Assert.AreEqual("Привет, Медвед  ", temp);
        }
    }
}