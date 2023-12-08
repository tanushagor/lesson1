using System;

public class Tasks
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < numbers.Length; i++){
            numbers[i] = rnd.Next(1, 100);
        }
        int cnt = 0;
        foreach (var item in numbers){
            if (item >= 20 && item <= 90)
            {   
                cnt++;
            }
        }
        Console.WriteLine(cnt);
        Console.ReadKey();
    }
}