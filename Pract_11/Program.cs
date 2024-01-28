//  Обработчик исключений. Оператор try-catch и блок finally!!!

using System;

namespace project {

    class Program {
        static void Main(){
            /*
            
            try {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            } catch(FormatException) {
                Console.WriteLine("Вы ввели не тот формат! ");
            }

    !!!

            try {
                int a = 5, b = 0, res;
                res = a / b;
            } catch(DivideByZeroException) {
                Console.WriteLine("Деление на ноль! ");
            }

            */

            try {
                int a, b, res;
                Console.Write("Введите первое число: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                b = Convert.ToInt32(Console.ReadLine());
                res = a / b;
                Console.WriteLine("Результат: " + res);
            } catch(DivideByZeroException) {
                Console.WriteLine("Деление на ноль! ");
            } catch(FormatException) {
                Console.WriteLine("Вы ввели не тот формат! ");
            } finally {

            }
            
        }

    }

}