using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1505_Part4_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int morePlay = 1, HowManyLettersLeftToGuess=0, NumOfTries =0;
            Random random = new Random();
            int wordChosenNumInArray = 0;
            string wordChosen = "";
            char[] wordGuessed = null;
            while (morePlay == 1)
            {
                //Game Gessing words
                string[] wordsBox =
                {
                "Returns", "records" , "that", "have", "matching", "values", "inin", "both","tables", "bothboth"
                };                
                wordChosenNumInArray = random.Next(0, wordsBox.Length);
                wordChosen = wordsBox[wordChosenNumInArray];
                wordGuessed = new char[wordChosen.Length];
                for (int i = 0; i < wordGuessed.Length; i++)
                {
                    wordGuessed[i] = '_';
                }
                Console.WriteLine($"wordChosen is {wordChosen}");
                Console.WriteLine("Game 'guessing words' has started!");

                for (int i = 0; i < wordChosen.Length; i++)
                {
                    Console.Write("_");
                }

                Console.WriteLine();
                HowManyLettersLeftToGuess = wordChosen.Length;
                while (HowManyLettersLeftToGuess > 0)
                {
                    Console.WriteLine("Please write one letter from the word:");
                    string letter = Console.ReadLine();

                    if (wordChosen.Contains(letter))
                    {
                        for (int i = 0; i < wordChosen.Length; i++)
                        {
                            if (wordChosen[i] == letter[0])
                            {
                                //Console.Write(wordChosen[i] + " ");
                                HowManyLettersLeftToGuess--;
                                for (int j = 0; j < wordChosen.Length; j++)
                                {
                                    if (j == i)
                                    {
                                        wordGuessed[j] = wordChosen[i];
                                    }
                                }
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine($"wordGuessed = {new string(wordGuessed)}");
                    }
                    else
                    {
                        Console.WriteLine("Wrong guess !!");
                    }
                    Console.WriteLine();
                    NumOfTries++;
                }

                Console.WriteLine($"Very Nice ! You guessed all the word ! Num Of Tries {NumOfTries}");
                Console.WriteLine("if you want to continue playing, press 1 else press 2");

                morePlay = Convert.ToInt32(Console.ReadLine());
                NumOfTries = 0;
            }            
        }
    }
}
