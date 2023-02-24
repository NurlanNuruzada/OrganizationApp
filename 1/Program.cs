#region task 1 (if else )
/*Console.WriteLine("a ededini daxil edin");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("b ededini daxil edin");
int b = int.Parse(Console.ReadLine());
if (a < b)
{
    Console.WriteLine("a kicikdir b den ");

}
else if (a == b)
{
    Console.WriteLine("a beraberdir b ye ");
}
else
{
    Console.WriteLine("b kicikdir a dan");
}
*/
#endregion
#region task2  (booolian type) 
/*Console.WriteLine("please enter username ");
string username = Console.ReadLine();
Console.WriteLine("please enter user password ");
string password = Console.ReadLine();
if (username == "dudus" && password == "1233169")
{
    Console.WriteLine("Welcome");
}
else
{
    Console.WriteLine("your pasword or username is valid");
}
*/



#endregion
#region task 3  (Switch case)
/*int number = int.Parse(Console.ReadLine());
switch (number)
{
    case 1:
        Console.WriteLine("monday");
        break;  
        case 2:
        Console.WriteLine("tuesday");
        break;
        case 3:
        Console.WriteLine("wednesday");
        break;  
        case 4:
        Console.WriteLine("thursday");
        break;
            case 5:
        Console.WriteLine("friday");
                break;
        case 6:
    case 7:
        Console.WriteLine("weekend");
        break;
    default:
        Console.WriteLine("u entered wrong number");
        break;

        */
#endregion 
#region task 4(ehile do while)
/*int number = 0;
while (number < 69)
{
    number++;
    Console.WriteLine(number);
}

int number = 0;
do
{
    Console.WriteLine($"do While = {++number}");
} while (number < 0);
*/
#endregion
#region task 5 (for ile tek ededler)
/*int n = 11;
int m = 15;
int sum = 0;
for (int i = n; i < m; i++)
{
    if (i % 2 == 0)
    {
        ++i;
    }
    Console.WriteLine(i);
}*/



#endregion

#region task (1 Qeyd; bug olarag sonuncu reqemi de daxil edir  )
//n den m e kimi tek ededlerin cemini tapin n<m
/*Console.WriteLine("Input positive number1:");
int number1=int.Parse(Console.ReadLine());
Console.WriteLine("Input positive number greater than greather than number1:");
int number2=int.Parse(Console.ReadLine());
int result = 0;
while (number1 < number2)
{
number1 ++; 
  if (number1 > number2) 
    {
     Console.WriteLine("number2 must be greater than number1 "); 
    break;
    }
    else if (number1 < 0) 
    {  
    Console.WriteLine("enter positive number"); 
    break;
    }
    else if (number1%2==0) continue;    
    result+=number1;
}
Console.WriteLine($"Sum:{result}");
*/
#endregion
#region task 2 
//Verilmish ededin 3-un quvveti olub-olmamasini tapin
using System;
//int number = int.Parse(Console.ReadLine());
int number = 2;
int pow = 1;
while (number >= pow)
{
    pow *= 3;
}
if (number == pow)
{
    Console.WriteLine("3-un quvvetidir");
}
else { Console.WriteLine("3-un quvveti deyil"); }
#endregion


