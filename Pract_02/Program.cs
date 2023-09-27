/*  Создание и работа с переменной!

int number = -10;
Console.WriteLine(number);
number = 10;                    "number" - можно видоизменять сколько угодно раз.
Console.WriteLine(number);
number = 5;
Console.WriteLine(number);

Вывод: 
-10
10
5

*/

/*  Вывод информации!

int number = -10;
Console.WriteLine("Переменная: " + number + ".");   - вывод информации.    

Вывод:
Переменная: -10.

*/

/*  Типы данных в C#. Целые числа!

uint number = 10;   - "uint" - внутри этой переменной можно хранить только те числа которые будут положительные.
byte number = 10;   - "byte" - разница между переменной "uint" только в том что мы можем хранить до определённого значения 255.
short number = 10;  - "short" - мы можем хранить от -32650 и до определённого значения 32650.
int number = 10;    - "int" - мы можем хранить от -2 млрд и до определённого значения 2 млрд.
long number = 10;    - "int" - выход за диапазон "int".

*/

/*   Типы данных в C#. Числа с точкой!

float num = 4.5345f;    - "float" - число с точкой от и до +-1 млн и обязательно с окончанием "f" для корректной работы.
double num = 4.5345d;   - "double" - число с точкой от и до больше дмапазон чем "float" в два раза и обязательно с окончанием "d" для корректной работы.

*/

/*  Другие типы данных!

1) string word = "Hello ";  - "string" - позволяет хранить определённую строку.
Пример:

int number = -10;
string word = "Переменная: ";
Console.WriteLine(word + number + "."); 

2) char symbol = 's';    - "char" - позволяет хранить один определённый символ в одинарных кввычках.
Пример:

int number = -10;
char symbol = 's';
Console.WriteLine(symbol + number + "."); 

3) bool isHappy = true;
   bool isHappy = false;    - позволяет хранить одно из двух возможных значений "true"(истина) или "false"(ложь).

*/

int num_1 = 0, num_2 = 0;

Console.WriteLine("Введите два числа: ");
num_1 = Convert.ToInt32(Console.ReadLine());
num_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("First: " + num_1 + ". Second: " + num_2 + ".");
