/*  Создание мини программы!

  double user_input;
user_input = Consvert.ToDouble(Console.ReadLine());     - для типов данных double.

!!!

  Console.WriteLine("Введите число с точкой: ");
float user_input = float.Parse(Console.ReadLine());

Простые математические действия!

float result;
result = user_input + 10f;
  result = user_input - 10f; - вычитание.
  result = user_input * 10f; - умножение.
  result = user_input / 10f; - деление.
  result = user_input % 10f; - остаток при делении.

int a = 5; b = 6;
int res = a + b;
  int res = a - b; - вычитание.
  int res = a * b; - умножение.
  int res = a / b; - деление.
  int res = a % b; - остаток при делении.
 
Сокращенные действия!

  result += 5f;
 result -= 5f;
 result *= 2f;
 result /= 5f;
 
 Это всë математические действия к переменной.

  
  result ++; // Прибавление или вычитание одного значения переменной.
  
  
  Console.WriteLine("Переменная: " + user_input);

  */

/*  Встроенные математические функции!

Console.WriteLine(Math.PI);
  Обращение к константе через класс "Math", пример число "PI".


Console.WriteLine(Math.Abs(-20));
  Обращение к функции через класс "Math", пример "Abs" позволяет получить число по модулю.

  Console.WriteLine(Math.Ceiling(4.11f));
  // Обращение к функции через класс "Math", пример "Ceiling" принимает определённое число (обычно с точкой) и она всегда округляет это число к большему.

  Console.WriteLine(Math.Floor(4.99f));
  // Обращение к функции через класс "Math", пример "Floor" принимает определённое число (обычно с точкой) и она всегда округляет это число к меньшему.

  Console.WriteLine(Math.Round(4.56f));
  // Обращение к функции через класс "Math", пример "Round" принимает определённое число (обычно с точкой) и она округляет это число к большему либо к меньшему.

  Console.WriteLine(Math.Min(5, 0));
  // Обращение к функции через класс "Math", пример "Min" позволяет получить минимальное число из двух возможных.

Console.WriteLine(Math.Max(5, 0));
  // Обращение к функции через класс "Math", пример "Max" позволяет получить максимальное число из двух возможных.

Console.WriteLine(Math.Pow(5, 2));
  // Обращение к функции через класс "Math", пример "Pow" позволяет число возвести в определённую степень.

*/


System.Console.WriteLine("Введите радиус круга: ");
double radius = Convert.ToDouble(Console.ReadLine());
double area = Math.PI * Math.Pow(radius, 2);
System.Console.WriteLine("Площадь круга с радиусом {0} равна {1}", radius, area);

