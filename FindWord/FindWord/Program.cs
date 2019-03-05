using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWord
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the word to find : ");
            string wordToFind = Console.ReadLine();

            string word;
            int i = 0;
            do
            {
                word = Generator.GenerateWord(wordToFind.Length);
                Coloring.RandomColoredWrite(word + " ");
                i++;
            }
            while (word != wordToFind);

            Console.WriteLine("\n"+"This word is number " + i + "\n");
            Console.ReadLine();
        }
    }
}
