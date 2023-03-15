using Hometask2;

Person p1= new Person();
p1.Age=7;
Person p2= new Person();
p2.Age = 2;
Person[] arr = {p1,p2};
    int i = 0;
    int j = i + 1;
if (arr[j] < arr[i])
{
    Person temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}
foreach (Person p in arr)
    Console.WriteLine(p.Age);
