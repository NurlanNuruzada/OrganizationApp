
#region practise with methods (arry and integer and string types)
/*
int primalnumtest (int num)
{

bool tester = false;
for (int i = 2; i < num; i++)
{
    if (num % i == 0)
    {
        tester = true;
        break;
    }
}
if (tester)
{
    console.writeline("the number is complex");
}
else
{
    console.writeline("the number is primal");
}return num;

}
int divisors (int number)
{
    console.writeline($"dvisors of the {number} :");

    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            console.writeline(i);
        }
    }
    return number;
}
int evenprimdrivisor (int number)
{
    for (int i = number; 1 < i; i--)
    {
        if (number % i == 0)
        {
            bool test = false;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                    test = true;
                continue;
            }
            if (!test)
            {
                console.writeline("the even divisor of number =" +i);
                break;
            }
        }
    }
    return number;
}
int powofnum (int number)
{
int result = 1;
{
            console.writeline($"the 10 pow of {number}  :");
    for (int i = 0; i < 10; i++) 
    {
        result *= number;
        console.writeline($"{number} ^ {i} = {result}");
    }
}return number;
}
int multiler (int number)
{
int result = 0;
{
    console.writeline($"the  10 times {number}(number)  :");
    for (int i = 1; i <= 10;i++)
    {
         result = number * i;
        console.writeline($"{number} x {i} = {result}");

    }
}
return number;
}
primalnumtest(11);
evenprimdrivisor(121);
divisors(11);
powofnum(3);
multiler(11);
*/
#endregion
#region practice 2
string word;
//string repead (out string word ,int number)
//{
//    word = "nurlan";
//    string words = "";
//    while (number > 0)
//    {
//        number = number - 1;
//        words += word;
//    }
//        console.writeline(words);
//return words;
//}
//repead(out word,3);
#endregion
#region arry params 
//int arry (params int[] arr)
//{
//    foreach (int item in arr)
//    {
//        console.writeline(item);
//    }
//    return 0;
//}
//arry (23,23,1,3,12,21,3,13);
#endregion
#region params isle duzelmis min max duzelt 
//int[] arry = { 123, 123, 1, 23, 2, 43, 234 };
//int minnumber (params int[] arry)
//{
//        int min = arry[0];
//    foreach(int item in arry)
//    {
//        if (item < min  )
//        {
//            min = item;
//        }
//    }
//return min;
//}
//console.writeline(   minnumber(13, 123, 12, 3, 123, 123, 213, 2, 24, 31));
#endregion
#region her hansi bir arry daki en boyuk eded qeder repead elemek 
//int Max (params int[] arr)
//{
//    int max = arr[0];
//    foreach(int item in arr)
//    {
//        if (item > max)
//        {
//        max = item;
//        }
//    }
//return max;
//}
//string WordRepead (string word ,int number)
//{
//    string repead = "";
//    while (number> 0)
//    {
//        repead += word;
//        number--;
//    }
//    return repead;
//}
//Console.WriteLine( WordRepead("Nurlan", Max( 1, 2, 3, 12)) );
#endregion
/*int  defaultarr(int number = 12,params int[] arrs)
{
    Console.WriteLine(number);
    int min = arrs[0];
    foreach (int item in arrs)
    {
        if (item < min)
        {
            min = item;
        }
    }
    return min;
}
defaultarr(number:7 ,arrs: 213, 4, 12, 12, 11); */

#region metod overloading 
int FindMinimum(int number = 3, params int[] values)
{
    Console.WriteLine($"Number: {number}");

    int min = values[0];
    foreach (int value in values)
    {
        if (value > min)
        {
            min = value;
        }
    }

    return min;
}
FindMinimum(number: 123,values: 34, 45, 234, 54);

#endregion