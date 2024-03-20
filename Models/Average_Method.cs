namespace Homework.Models;

public class Average_Method
{
    public static void CalcAvg(int[] scores)
    {
        int sum = 0;
        int count = 0;
        foreach(int score in scores)
        {
            sum += score;
            count++;
        }
        if (sum/count>60)
        {
            Console.WriteLine("Mezun oldunuz");
        }
        else
        {
            Console.WriteLine("Mezun ola bilmediniz");
        }
    }
}
