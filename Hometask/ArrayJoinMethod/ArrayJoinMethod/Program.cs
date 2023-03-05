//her bir indexin arasinda seperator isledir sonra ise
// onu string bir metoda cevirir

string CustomJoin(int [] arr, string separator)
{
    string result = "";
    for (int i = 0; i < arr.Length - 1; i++)
    {
        result += arr[i] + separator;

    }
    return result+=arr[arr.Length-1];
}
// TEST UCUN YAZDIM ASAGINI
Console.WriteLine( CustomJoin(new int[] { 1, 2, 3, 433, 5, 6, 7, + 8 },"--"));

