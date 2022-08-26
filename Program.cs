// See https://aka.ms/new-console-template for more information
public class Program
{
    public static string InputName()
    {
        Console.Write("Input name :");

        return Console.ReadLine();
    }

    public static string InputScore()
    {
        Console.Write("Input score :");

        return Console.ReadLine();
    }

    public static int ConvertStringToInt(string value)
    {
        if (int.TryParse(value, out int number))
        {
            return number;
        }

        throw new Exception("Please input decimal data.");
    }

    public static string ConvertScoreToGrade(int score)
    {
        if (score > 100) { throw new Exception("Please input number 0-100");}

        if (IsGradeA(score))
        {
            return "Grade A";
        }
        else if (IsGradeBPlus(score))
        {
            return "Grade B+";
        }
        else if (IsGradeB(score))
        {
            return "Grade B";
        }
        else if (IsGradeCPlus(score))
        {
            return "Grade C+";
        }
        else if (IsGradeC(score))
        {
            return "Grade C";
        }
        else if (IsGradeDPlus(score))
        {
            return "Grade D+";
        }
        else if (IsGradeD(score))
        {
            return "Grade D";
        }
        else
        {
            return "Grade F";
        }
    }

    public static bool IsGradeA(int score)
    {
        return score <= 100 && score >=80;
    }
    
    public static bool IsGradeBPlus(int score)
    {
        return score < 80 && score >=75;
    }

    public static bool IsGradeB(int score)
    {
        return score < 75 && score >=70;
    }

    public static bool IsGradeCPlus(int score)
    {
        return score < 70 && score >=65;
    }

    public static bool IsGradeC(int score)
    {
        return score < 65 && score >=60;
    }

    public static bool IsGradeDPlus(int score)
    {
        return score < 60 && score >=55;
    }

    public static bool IsGradeD(int score)
    {
        int maxScoreGradeD = 54;
        int minScoreGradeD = 50;
        return score <= maxScoreGradeD && score >= minScoreGradeD;
    }

    static void PrintInputInfomation(string name, string InputScore, string grade)
    {
        Console.WriteLine();
        Console.WriteLine("**********************************************");
        Console.WriteLine("Name is: {0}", name);
        Console.WriteLine("Score is: {0}", InputScore);
        Console.WriteLine("Grade is: {0}", grade);
        Console.WriteLine("**********************************************");
    }

    static void Main(string[] args)
    {
        string name = InputName();
        string scoreText = InputScore();
        int scoreDecimal = ConvertStringToInt(scoreText);
        string grade = ConvertScoreToGrade(scoreDecimal);

        PrintInputInfomation(name, scoreText, grade);
    }
}


