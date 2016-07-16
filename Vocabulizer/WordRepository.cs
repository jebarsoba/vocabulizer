using System.Collections.Generic;

namespace Vocabulizer
{
    public static class WordRepository
    {
        private static List<string> stringWords = new List<string>();
        private static List<Word> pocoWords = new List<Word>();

        public static void Add(string word)
        {
            stringWords.Add(word);
        }

        public static void Add(Word word)
        {
            pocoWords.Add(word);
        }

        public static IList<string> GetAll()
        {
            return stringWords;
        }

        public static IList<Word> GetAllPocoWords()
        {
            return pocoWords;
        }
    }
}