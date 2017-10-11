using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Pig_Latin_Sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PigIt("Pig latin is cool"));
            Console.ReadLine();
        }

        public static string PigIt(string str)
        {
            string trimmedSentence = str;
            string pigSentence = "";
            string singleWord = "";
            int nextSpaceLoc;

            while (trimmedSentence.Contains(" "))
            {
                nextSpaceLoc = trimmedSentence.IndexOf(" ");
                singleWord = trimmedSentence.Substring(0, nextSpaceLoc);
                pigSentence += PigWord(singleWord) + " ";
                trimmedSentence = trimmedSentence.Substring(nextSpaceLoc + 1, trimmedSentence.Length - nextSpaceLoc - 1);   //chops off the word that has just been translated and added to the final sentence

            }
            pigSentence += PigWord(trimmedSentence);     //for the last word of the sentence

            return pigSentence;
        }

        public static string PigWord(string word)
        {
            string pigWord = word.Substring(1, (word.Length - 1)) + word[0] + "ay";
            return pigWord;
        }
    }
}
