using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };


string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

foreach (string currentStudent in studentNames)
{
    int[] studentScores = new int[10];

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;

    decimal studentSum = 0;

    decimal studentScore;
    string studentLetterGrade;

    int i = 1;
    foreach (int score in studentScores)
    {
        if (i > 5)
        {
            studentSum += score / 10;
        }
        else
        {
            studentSum += score;
        }
        i++;
    }

    studentScore = (decimal)studentSum / currentAssignments;

    if (studentScore >= 97)
        studentLetterGrade = "A+";

    else if (studentScore >= 93)
        studentLetterGrade = "A";

    else if (studentScore >= 90)
        studentLetterGrade = "A-";

    else if (studentScore >= 87)
        studentLetterGrade = "B+";

    else if (studentScore >= 83)
        studentLetterGrade = "B";

    else if (studentScore >= 80)
        studentLetterGrade = "B-";

    else if (studentScore >= 77)
        studentLetterGrade = "C+";

    else if (studentScore >= 73)
        studentLetterGrade = "C";

    else if (studentScore >= 70)
        studentLetterGrade = "C-";

    else if (studentScore >= 67)
        studentLetterGrade = "D+";

    else if (studentScore >= 63)
        studentLetterGrade = "D";

    else if (studentScore >= 60)
        studentLetterGrade = "D-";
    else
        studentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{studentScore}\t{studentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();