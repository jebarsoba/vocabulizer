using System;
using System.Collections.Generic;
using DAL;

namespace Vocabulizer
{
    public class WordRandomizer
    {
        private List<Word> words;
        private List<Word> alreadyUsedWords = new List<Word>();

        public WordRandomizer(List<Word> words)
        {
            this.words = words;
        }

        public Word GetRandomWord()
        {
            int randomSeed = DateTime.Now.Millisecond;

            Word word = this.words[new Random(randomSeed).Next(0, this.words.Count)];

            while (this.alreadyUsedWords.Contains(word))
                word = this.words[new Random(++randomSeed).Next(0, this.words.Count)];

            this.alreadyUsedWords.Add(word);

            if (this.HaveIUsedEveryWord())
                this.alreadyUsedWords.Clear();

            return word;
        }

        private bool HaveIUsedEveryWord()
        {
            return this.alreadyUsedWords.Count == this.words.Count;
        }
    }
}