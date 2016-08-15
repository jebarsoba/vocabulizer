using DAL;
using NUnit.Framework;
using System.Collections.Generic;

namespace Vocabulizer.Test
{
    [TestFixture]
    public class WordRandomizerTest
    {
        List<Word> words;
        WordRandomizer wordRandomizer;

        [TestFixtureSetUp]
        public void SetUp()
        {
            words = new List<Word>();
            words.Add(new Word() { source = "Hello", target = "Hola" });
            words.Add(new Word() { source = "Bye", target = "Chau" });

            wordRandomizer = new WordRandomizer(words);
        }

        [Test]
        public void GetWordTest()
        {
            Word firstWord = wordRandomizer.GetRandomWord();
            Word secondWord = wordRandomizer.GetRandomWord();

            Assert.AreNotEqual(firstWord.source, secondWord.source);
            Assert.AreNotEqual(firstWord.target, secondWord.target);
        }

        [Test]
        public void UseEveryWordAndTryToUseOneOfThemAgainTest()
        {
            Word firstTry = wordRandomizer.GetRandomWord();
            Word secondTry = wordRandomizer.GetRandomWord();
            Word thirdTry = wordRandomizer.GetRandomWord();

            Assert.AreNotEqual(firstTry.source, secondTry.source);
            Assert.AreNotEqual(firstTry.target, secondTry.target);
        }
    }
}