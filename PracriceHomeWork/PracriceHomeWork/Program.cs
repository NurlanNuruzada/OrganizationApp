//int[] arr = { 1, 23, 4, 5, 6, 7, 8 };
//int[] ReverseArray(int[] array)
//{
//int i = 0;
//int j = arr.Length-1;
//while (i < j)
//{
//    var temp = arr[i];
//    arr[i] = arr[j];
//    arr[j] = temp;
//    j--; i++;


//}
//return arr;

//}
//ReverseArray(arr);
//foreach (int item in arr)
//{
//    Console.WriteLine(item);
//}
string Seperator(string Seperator,params int[] arr)
{
    string result = "";
    for (int i = 0; i < arr.Length;i++)
    {
        result += arr[i] +Seperator ;
    }
    return result+arr[arr.Length-1];
}
Console.WriteLine( Seperator("--",1,2, 3, 4, 5, 6, 7, 7) ); 
