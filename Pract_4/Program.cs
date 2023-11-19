/* Создание условной конструкции!

int a = 5;

if(a == 5); 
    if(a > 5);  ">" - больше.
    if(a < 5);  "<" - меньше.
    if(a >= 5); ">=" - больше или равно.        --- ЭТО ВСЁ ЛОГИЧЕСКИЕ ОПЕРАТОРЫ!!!
    if(a <= 5); "<=" - меньше или равно.
    if(a != 5); "!=" - не равно.

{
    System.Console.WriteLine("Number is 5 ");
}

int a = 5;

if(a == 5)  
    if(a > 5)  ">" - больше.
    if(a < 5)  "<" - меньше.
    if(a >= 5) ">=" - больше или равно.        --- ЭТО ВСЁ ЛОГИЧЕСКИЕ ОПЕРАТОРЫ!!!
    if(a <= 5) "<=" - меньше или равно.
    if(a != 5) "!="   - не равно.
*/

/*

int a = 5;
bool isHasCar = false;

if(a > 7)

    System.Console.WriteLine("Number > 7 "); 
else if(a < 5)  

        Console.WriteLine("Number is < 5 ");
else if(a == 4)  

        Console.WriteLine("Number is 4 ");
else if((a == 5 || isHasCar) && a > 2)  
{
        Console.WriteLine("Number is 5 ");
        //if (isHasCar)
            Console.WriteLine("User has car! ");
}
else

    Console.WriteLine("Number is unrecognized! ");

    */

System.Console.WriteLine("Enter name: ");
string role = Console.ReadLine();

if (role == "Admin")
{
    Console.WriteLine("Enter user name: ");
    string user_name = Console.ReadLine();
    Console.WriteLine("Enter {0} age: ", user_name);
    short age = Convert.ToInt16(Console.ReadLine());

    if(age <= 0 || age > 99) {
        Console.WriteLine("Enter {0} age: ", user_name);
        age = Convert.ToInt16(Console.ReadLine());
    }

    if(age <= 0 || age > 99) {
        Console.WriteLine("Error ");
        age = 0;
    }
        else
        System.Console.WriteLine("User's age is " + age);
       
}
else
    System.Console.WriteLine("You are not admin! ");
