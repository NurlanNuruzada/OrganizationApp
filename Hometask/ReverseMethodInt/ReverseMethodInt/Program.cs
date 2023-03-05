int[] arr = { 11, 23, 45, 6, 44, 55, 66, 77, 88, 66 };
void ReverseArray(int[] arr)
{
    int i = 0;
    int j = arr.Length - 1;
    while (i < j) // 0 dan arr-in Lenght-ne qeder yoxlayir
    {
        // yaridan sonra i nin indexsi j nin indexsine beraber olur onda gore half
        var Changing = arr[i];
        arr[i] = arr[j];
        arr[j] = Changing;
        i++; j--;
    }
}
//yoxlamaq ucun yazmisam
ReverseArray(arr);
foreach (int item in arr)
{
    Console.WriteLine(item);
}

