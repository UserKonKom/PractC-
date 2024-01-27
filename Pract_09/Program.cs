/* Создание функций (методов класса)!

using System;

namespace project {

    class Program {
        static void Main(){
         
            //Print("Hello");
            //Print("Hello world!");    - Передача параметров в функцию!
            // Print();
            
            Summa(5, 6);
            int a = 4, b = 7;   - Функция для сложения чисел!
            Summa(a, b);
        }

        public static void Print(string word) {     - Передача параметров в функцию!
            System.Console.WriteLine(word);
        }

         public static void Summa(int x, int y) {   - Функция для сложения чисел!
            int res = x + y;
            Print("Результат: " + res);
        }
        
        !!! Возвращения значения !!!

            int res1 = Summa(5, 9);
            int a = 4, b = 7;
            int res2 = Summa(a, b);

            Print(res1.ToString());
            Print(res2.ToString());
        }

        public static void Print(string word) {
            System.Console.WriteLine(word);
        }

        public static int Summa(int x, int y) {
            return x + y;
        }
    }
}

*/

using System;

namespace project {

    class Program {
        static void Main(){
            byte[] nums = [5, 7, 8, 3, 5];
            byte res1 = Summa(nums);
            Console.WriteLine("Результат: " + res1);

            byte[] nums1 = [5, 3, 8, 3, 5];
            byte res2 = Summa(nums1);
            Console.WriteLine("Результат: " + res2);
        }

        public static byte Summa(byte[] digits) {
            byte summ = 0;
            foreach(byte el in digits)
                summ += el;

            return summ;
        }

    }

}