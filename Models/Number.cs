namespace Homework.Models;

public class Number
{
    public static void DifferenceNumbers(int[] array, int[] array1)
    {
        for (int i = 0; i<array.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < array1.Length; j++)
            {
                if (array[i]==array1[j])
                {
                    count++;
                }
            }
            if (count==0) Console.WriteLine(array[i]);
        }
    }
}
