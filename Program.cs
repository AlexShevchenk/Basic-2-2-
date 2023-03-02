using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[100];
        int[] arrA = new int[20];
        int[] arrB = new int[20];
        int j = 0;
        int count = 0;

        Random rnd = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(-1000, 1000);
            if (arr[i] >= -100 && arr[i] <= 100)
            {
                count++;
            }
        }
        for (int i = 0; i < arrA.Length; i++)
        {
            arrA[i] = rnd.Next(-1000, 1000);
            if (arrA[i] <= 888)
            {
                arrB[j] = arrA[i];
                j++;
            }
        }

        Array.Sort(arrB);
        Array.Reverse(arrB);

        Console.WriteLine("Sorted array B:");
        for (int i = 0; i < arrB.Length; i++)
        {
            Console.WriteLine(arrB[i]);
        }


        Console.WriteLine("Numbel Of elements -100 and +100" + count);
    }

}
