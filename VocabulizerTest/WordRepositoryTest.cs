using NUnit.Framework;
using Vocabulizer;

namespace VocabulizerTest
{
    [TestFixture]
    public class WordRepositoryTest
    {
        [Test]
        public void AddTest()
        {
            WordRepository.Add("hello/hola");

            Assert.AreEqual(1, WordRepository.GetAll().Count);
        }

        [Test]
        public void AddWordTest()
        {
            Word word = new Word("hello", "hola");

            WordRepository.Add(word);

            Assert.AreEqual(1, WordRepository.GetAllPocoWords().Count);
        }
    }
}