/*  Цикл for, while и do while. Операторы циклов!

!!! 

for(float i = 200; i > 10; i /= 2)   {
    Console.WriteLine("Element: {0}", i);
}

!!! Отдичие от цикла "for", то что мы указываем только условие.

byte i = 10;
while(i >= 1)   {
    Console.WriteLine("Element: {0}, i);
    i--
}

!!!

bool isHasCar = true;
while(isHasCar) {
    string end = Console.ReadLine();
    if(end == "end")
        isHasCar = false;
}

!!!

byte i = 100;

do {
    Console.WriteLine("Element: " + i);
} while(i < 10);

*/

for(short i = 0; i < 10; i++)   {
    //if(1 > 5)
    //break;

    if(i % 2 == 0)
        continue;

    Console.WriteLine("El: " + i);
}

// "continue" - пропускает один круг цикла.