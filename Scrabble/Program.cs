using System;
using Scrabble.Models;

class program
{

    public static void Main()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        TypeLine("Please enter a word: (no numbers or special characters please)");
        string inputWord = Console.ReadLine().ToLower();
        ScrabbleScore newScore = new ScrabbleScore();

        bool isWord = newScore.CheckWord(inputWord);
        if(isWord)
        {
            int finalScore = newScore.GetScore(inputWord);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeLine("Your Scrabble Score:");
            foreach (string detail in newScore.ScoreDetails)
            {
                TypeLine(detail);
            }
            TypeLine("Your final score is: " + finalScore + ".");
        }
        else
        {
            Console.Clear();
            ErrorMessage();
        }
    }

    public static void ErrorMessage()
    {
        Console.Write(Environment.NewLine);
        Console.ForegroundColor = ConsoleColor.Red;
        TypeLine("That wasn't a valid word, please use ONLY letters. Let's try again in....");
        TypeLine("3........................");
        System.Threading.Thread.Sleep(300);
        TypeLine("2..................................");
        System.Threading.Thread.Sleep(300);
        TypeLine("1...........................................");
        System.Threading.Thread.Sleep(300);
        Console.ForegroundColor = ConsoleColor.White;
        Main(); 
    }

    public static void TypeLine(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(input[i]);
            System.Threading.Thread.Sleep(25);
        }
        Console.Write(Environment.NewLine);
        Console.Write(Environment.NewLine);
    }

}