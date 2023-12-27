using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

class ConsoleGame
{

    public static void PlayerList()
    {

        List<string> playersName = new List<string>
        {
            "Jack",
            "Jill",
        };

        List<List<string>> AllUsers = new List<List<string>>
        {
            new List<string> {"Jack", "Jill"},
        };
        Console.WriteLine(AllUsers[0][0]);
    }

    public static void RollDice()
    {
        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        }

        if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples! +6 bonus to total!");
            total += 6;
        }

        if (total >= 15)
        {
            Console.WriteLine("You win!");
        }

        if (total < 15)
        {
            Console.WriteLine("Sorry, you lose.");
        }
    }

    public static void Main(string[] args)
    {
        // Console.WriteLine("Welcome to the Dice Roller!");
        // Console.WriteLine("Press enter to roll the dice.");
        // Console.ReadLine();
        // RollDice();
        // PlayerList();
        //SophiaScores();
        // Console.WriteLine("Press enter to exit.");
        // Console.ReadLine();
        maxProductDifference();
    }

    public static void SophiaScores()
    {
        int currentAssignment = 5;
        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
        string[] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"};
        int[] studentScores = new int[10];

        foreach(string name in studentNames)
        {
            if(name== "Sophia")
                studentScores = sophiaScores;
            else if(name== "Andrew")
                studentScores = andrewScores;
            else if(name== "Emma")
                studentScores = emmaScores;
            else if(name== "Logan")
                studentScores = loganScores;

                int sum = 0;
                decimal studentScore;
                foreach(int score in studentScores) 
                {
                    sum += score;
                }
                
                     studentScore = (decimal)sum / currentAssignment;
                     Console.WriteLine(studentScore);
                     CallConvertToLetterGrade(studentScore);
        }
    }
    private static void CallConvertToLetterGrade(decimal currentStudentGrade)
    {
    string currentStudentLetterGrade;
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"\t\t{currentStudentLetterGrade}\t?");
    }

    private static void maxProductDifference() 
    {
        int min1 = int.MaxValue;
        int min2 = int.MaxValue;
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        int[] nums = new int[] {7,8,2,9};
        foreach(int num in nums)
        {
            if(num <= min1)
            {
                min2 = min1;
                min1= num;
            } else if (num < min2) 
            {
                min2 = num;
            }

            if(num >= max1)
            {
                max2 = max1;
                max1= num;
            } else if (num > max2) 
            {
                max2 = num;
            }
        }

        int product = (max1 * max2) - (min1 * min2);
        Console.WriteLine(product);
    }
}


