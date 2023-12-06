using System.ComponentModel.DataAnnotations;

public class Lab1
{
    static void Main(string[] args)
    {
        var vec = GenerateRandomVector(10);
        PrintVector(vec);
        int sum2 = GetSum(vec);
       
        
        int sum = GetSumBeforeZero(GenerateRandomVector(10));
        Console.WriteLine("Sum before the first zero: {0}", sum);
        Console.WriteLine("Sum positive: {0}", sum2);


        Console.ReadLine();
    }
    public static int GetSum(int[] array)
    {
        int sum1 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum1 += array[i];
            }
        }
        return sum1;
    }
    static void PrintVector(int[] vec)
    {
        Console.WriteLine(string.Join(", ", vec));
    }
    
    static int[] GenerateRandomVector(int length)
    {
        var array = new int[length];
        var random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 10);
        }
        Array.Sort(array);

        return array;
    }
    
    public static int GetSumBeforeZero(int[] array)
    {
        var sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            var current = array[i];
            if (current == 0)
                break;

            sum += current;
        }

        return sum;
    }
    //public static void ArraySorting(int[] array)
   // {
       // int [] sortedArray = new int[array.Length];
        //for (int j = 0; j < array.Length; j++)
        //{
           // if (array[j] >= 0)

                
        //}

   // }
}