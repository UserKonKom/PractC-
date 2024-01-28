/* using System;

namespace project {

    class Program {
        static void Main(){
            !!! Строка как массив данных !!!
           
           string word = "Hello";
           word += "!!!";

           // Console.WriteLine(word[1]);   - обращение к любому элемента массива.
           // Console.WriteLine(word.Length);   - подсчёт кол-во элементов.

             !!! Методы по работе со строками !!!

            string word = "Hello";
            word += "!";

            word = String.Concat(word, "!!");    - функция "String.Concat()" позволяет взять определённую строку и добавить подстроку.
            Console.WriteLine(word);
            
            !!!

            string word = "Hello";
            word += "!";

            Console.WriteLine(String.Compare(word, "Hello"));    - функция "String.Compare()" сравнение строк.
            
            !!!

            string people = "Alex,Bob,John";
            string[] names = people.Split(new char[]{','});      - функция "Split()" разбивает строку по опр-нному символу.
                foreach(string el in names)
                Console.WriteLine(el);
            
            !!!

                string[] names = people.Split(new char[]{','});     
                people = string.Join(" ", names);                   - функция "string.Join()" позволяет опр-нный массив будь то строки или числа, приоброзовать в строку который будет записан через опр-нный символ.
                Console.WriteLine(people);
            
            !!!

            string word = "Hello";
            word += "!";
            // Console.WriteLine(word.Trim());  - функция "Trim()" позволяет удалить лишние пробелы до и после строки.
            // Console.WriteLine(word.Substring(0, word.Length - 1));   - функция "Substring()" позволяет обрезать строку сначало или её конца.
        }

    }

}  

!!! Работа с файлами. Внесение данных !!!

using System;
using System.IO;

namespace project {

    class Program {
        static void Main(){
            System.Console.WriteLine("Введите текс: ");
            string text = Console.ReadLine();
            using(FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate)) {      - Внесение данных.
                byte[] array = System.Text.Encoding.Default.GetBytes(text);

                stream.Write(array, 0, array.Length);

            } 
        
            using(FileStream stream1 = File.OpenRead("info.txt")) {     - Считывание данных из файла.
                byte[] array = new byte[stream1.Length];
                stream1.Read(array, 0, array.Length);

                string textFromFile = System.Text.Encoding.Default.GetBytes(array);
                System.Console.WriteLine(textFromFile);

            }
        
        }

    }

}
*/