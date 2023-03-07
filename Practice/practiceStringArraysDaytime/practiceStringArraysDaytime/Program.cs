
#region Array 
using System.Reflection;

int[] Numbers;
string[] Fruits1;
int[] EvenNums = new int[3] { 1, 2, 4 };
string[] Fruits = new string[3] { "apple", "banana", "grapes" };
int[] Numbers2 = new int[3];
Numbers2[0] = 1;
//Ling Methods 
EvenNums.Max();
EvenNums.Min();
EvenNums.Sum();
EvenNums.Average();
// Array methods
int[] nums = { 1, 23, 4, 5, 6, 7 };
Array.Sort(nums);
Array.Clear(nums);
Array.Reverse(nums);
Array.BinarySearch(nums, 23);
//multidimentional arrays 
int[,] arr2d = new int[2, 3]
{
    {1, 2, 3 }, {4,5,6 },
};
Console.WriteLine(arr2d[0, 1]);
//jagged arrays
//array in arry simply
int[][] Jarry1 = new int[2][];
// can able to incude 2 single dimentional 
int[][,] Jarry2 = new int[3][,];
// can able to incude 3 dimentional 2 arry 
// the first brackeds means its value
// and seccond one means its dimention 





#endregion
#region String 
// string is sequece of characters
// create string in c#
string str1 = " Code academy";
string str2 = " Nurlan Nuruzade";
string emty = "";
// string Lenght 
int number = 0;
number = str1.Length;
Console.WriteLine(number);
emty = string.Concat("concat ops: " + str1, str2);
Console.WriteLine(emty);
// to compare 2 elemets we use Equals() boolean typedi
Boolean result = str1.Equals(str2);
Console.WriteLine(result);
// immutability of String is string cannot be changable
// we can just copy and assing the new values to it 

// string escape sequences 
//it means we can able to use special caracters 
string str = "this is test \"test\" mesage as u can see " +
    "we could able to use \"\" were ";
// to be able to use it we nee back slash "\\"
Console.WriteLine(str);

// methods in c sharp 
string.Format(str1, 'C', 'd');

// it splits the array by line by line 


#endregion
#region day time and other 
DateTime dt = new DateTime();
// assigns default value 01/01/0001 00:00:00
//The maximum value can be December 31, 9999 11:59:59 P.M.


//assigns year, month, day, hour, min, seconds, UTC timezone
DateTime time = new DateTime(2005, 02, 03);
DateTime timetoday = DateTime.Now; // return sinpyle time and date 
Console.WriteLine(timetoday);
DateTime toDaysDate = DateTime.Today;
Console.WriteLine(toDaysDate); // it shows only the date not time 
DateTime uts = DateTime.UtcNow; // returns current utc 
Console.WriteLine(uts); // returns the global time and date 
//Subtraction of two dates results in TimeSpan.
DateTime time1 = new DateTime(2005, 02, 03);
DateTime time2 = new DateTime(2023, 03, 06);
TimeSpan result2 = time2.Subtract(time1);
Console.WriteLine(result2);
Console.WriteLine(time2-time1);


#endregion