/*int number = 5;
double num = 2.415;
string name = "Galya";
char symbol = '#';
bool logic = true;



int number = 5;

Console.Write("My number is " + number);

int num;

Console.WriteLine("Input integer number; ");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is " + num);


int num1, num2, quad;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;

if(num1 == quad)
{
       Console.WriteLine("Yes");
}
else
{
       Console.WriteLine("No");
}



Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = num * (-1);

while(current <= num)

{
       Console.Write(current + " ");
       current++; // то же самое, что и current = current + 1;
}



1234 /10 -> 123
1234 /100 -> 12

1234 % 10 -> 4
1234 % 100 -> 34


1234 / 10 % 100 -> 23


int a = 132546454562;

while(a > 999)
{
       a /= 10; // тоже самое , что и a = a / 10;
}


Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num == 1) Console.Write("Понедельник");
if(num == 2) Console.Write("Вторник");
if(num == 3) Console.Write("Среда");
if(num == 4) Console.Write("Четверг");
if(num == 5) Console.Write("Пятница");
if(num == 6) Console.Write("Суббота");
if(num == 7) Console.Write("Воскресенье");
*/

Console.Write("Input first integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

num = num * num;

Console.Write(num);
