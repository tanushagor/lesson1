// 1
using System;

class TaskNumberOne
{
    public static void Main(string[] args)
    {
     while (true){
         string a = Console.ReadLine();
         if (a.Trim().ToLower() == "q"){
             Console.WriteLine("Программа завершена");
             break;
         }
         int n;
         if (int.TryParse(a, out n)){
             if(SumEven(n)) {
                 Console.WriteLine("Программа завершена. Сумма цифр введенного числа четная.");
                    break;
             }
         }
        else {
            Console.WriteLine("Некорректный ввод");
        }
     }
    }
    private static bool SumEven(int n){
        int sum = 0;
        while (n > 0){
            sum += n % 10;
            n /= 10;
        }
        return sum % 2 == 0;
    }
}

// 2
using System;

public class TaskNumberTwo
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < numbers.Length; i++){
            numbers[i] = rnd.Next(100, 1000);
        }
        int cnt = 0;
        foreach (var num in numbers){
            if (num % 2 == 0){
                cnt++;
            }
            Console.WriteLine(num);
        }
        Console.WriteLine(cnt);
        Console.ReadKey();
    }
}


// 3
using System;

public class TaskNumberThree
{
    public static void Main(string[] args)
    {
        int[] numbers = {5434, 24, 890, 234, 896, 53, 97, 11};
        Array.Reverse(numbers);
        Console.WriteLine(String.Join(',' + " ", numbers));
    }
}