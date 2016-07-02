using System.Collections.Generic;

namespace Vocabulizer
{
    public static class WordRepository
    {
        private static List<string> words = new List<string>();

        public static void Add(string word)
        {
            words.Add(word);
        }

        public static IList<string> GetAll()
        {
            return words;
        }
    }
}