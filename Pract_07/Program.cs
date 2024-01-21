/*  Массивы данных. Одномерные и многомерные!

byte[] nums = new byte[5];
nums[0] = 250;
nums[1] = 50;
nums[2] = 20;
nums[3] = 100;
nums[4] = 25;

//Console.WriteLine("El: " + nums[0]);

string[] words = new string[] {"John", "Bob", "Alex"};

words[1] = "Josh";

for(byte i = 0; i < nums.Length; i++)
System.Console.WriteLine("El: " + nums[i]);

!!!    

short[] numbers = new short[10];
short summa = 0;

Random random = new Random();
for(byte i = 0; i < numbers.Length; i++)    {
    numbers[i] = Convert.ToInt16(random.Next(-15, 15));
    Console.WriteLine("El: " + numbers[i]);
    
    summa += numbers[i];
}
Console.WriteLine("Summa: " + summa);

!!! 

char[] symbols = mew char[2, 3]; - одномерный массив.
char[,] symbols = mew char[2, 3]; - двухмерный массив.
symbols[0, 0] = 'N';
System.Console.WriteLine(symbols[0, 0]);

int[,] nums = {
    {4, 6, 7},
    {5, 7, 3},
    {3, 3, 2},
};

nums[1, 2] = 56;

*/
