using System;

public class Tasks
{
    public static void Main(string[] args)
    {
        double[] numbers = { 3.14, 2.71, 9.87, 5.55, 1.23 };
        double min = numbers[0];
        double max = numbers[0];
        foreach (double number in numbers)
        {
            if (number < min)
            {  
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }
        double difference = max - min; 
        Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
        
    }
}