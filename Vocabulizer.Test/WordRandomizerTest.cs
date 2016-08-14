using DAL;
using NUnit.Framework;
using System.Collections.Generic;

namespace Vocabulizer.Test
{
    [TestFixture]
    public class WordRandomizerTest
    {
        [Test]
        public void GetWordTest()
        {
            List<Word> words = new List<Word>();
            words.Add(new Word() { source = "Hello", target = "Hola" });
            words.Add(new Word() { source = "Bye", target = "Chau" });

            WordRandomizer wordRandomizer = new WordRandomizer(words);
            Word firstWord = wordRandomizer.GetRandomWord();
            Word secondWord = wordRandomizer.GetRandomWord();

            Assert.AreNotEqual(firstWord.source, secondWord.source);
            Assert.AreNotEqual(firstWord.target, secondWord.target);
        }

        [Test]
        public void UseEveryWordAndTryToUseOneOfThemAgainTest()
        {
            List<Word> words = new List<Word>();
            words.Add(new Word() { source = "Hello", target = "Hola" });
            words.Add(new Word() { source = "Bye", target = "Chau" });

            WordRandomizer wordRandomizer = new WordRandomizer(words);
            Word firstTry = wordRandomizer.GetRandomWord();
            Word secondTry = wordRandomizer.GetRandomWord();
            Word thridTry = wordRandomizer.GetRandomWord();

            Assert.AreNotEqual(firstTry.source, secondTry.source);
            Assert.AreNotEqual(firstTry.target, secondTry.target);
        }
    }
}