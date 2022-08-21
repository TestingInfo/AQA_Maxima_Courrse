using System;
using System.Text.RegularExpressions;

class Program
{
    /* Напишите консольный калькулятор
Получает на вход выражение вида "1*2" или "50-1" или "45/2"
Допустимые операции: *, /, +, -
На вход допускается только выражение с одной операцией
На вход попадают только целые числа, но результат может быть дробным
В строке на вход могут быть лишние пробелы вроде "55 -8"
Вывод приложения = или сообщение об ошибке или результат выражения
Приложение выдает ошибку как минимум, если входные данные в неверном формате */


    public static void Main(string[] args)
    {
        try
        {
            string userMathOperation = Console.ReadLine();

            char[] operat = { '-', '+', '*', '/' };
        
            var arr = userMathOperation.Split(operat, StringSplitOptions.None);
            
            int arg1 = int.Parse(arr[0]);
            int arg2 = int.Parse(arr[1]);
        
            if (userMathOperation.Contains("-"))
                Console.WriteLine((arg1 - arg2));
            else if (userMathOperation.Contains("+"))
                Console.WriteLine(arg1 + arg2);
            else if (userMathOperation.Contains("/"))
                if (arg2 == 0)
                {
                    Console.WriteLine("На ноль делить нельзя");
                }
                else
                {
                    Console.WriteLine(arg1 * 1.0 / arg2);
                }
            else
                Console.WriteLine(arg1 * arg2);
        }
        catch (FormatException)
        {
            Console.WriteLine("Вы ввели данные в неверном формате");
            
        }
    }
}




