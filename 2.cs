using System;

public class Tasks
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 78, 45, 92, 7, 66};
        int cnt = 0;
        foreach (var item in numbers){
            if (item % 2 == 0)
            {   
                cnt++;
            }
        }
        Console.WriteLine(cnt);
        Console.ReadKey();
    }
}