using System;
using System.Text;

namespace FindWord
{
    
    static class Generator
    {
        static Random rand = new Random();

        //Use char and converting int to chars instead of an array of letters
        private static string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        
        public static string GenerateWord(int length)
        {
            //Use string builder
            StringBuilder word = new StringBuilder(length);
            //string word = "";
            for (int i = 0; i < length; i++)
            {
                word.Append(letters[rand.Next(0, letters.Length - 1)]);
            }
            return word.ToString();
        }

    }
}
