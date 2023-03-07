using ConsoleApp3;
Fruits Apple = new Fruits();
Apple.Name = "Apple";
Apple.Description = "its is kins of round fruit ";
Apple.Color = "red,green,yellow ";
Apple.taste = "its sweet";
Console.WriteLine(Apple.GetInfo1());
Console.WriteLine("222=" + Apple.Description2());

vegtable carrot = new vegtable();
carrot.Name = "carrot";
carrot.Description = "its tough";
carrot.Color = "orange";
carrot.taste = "little swetnes";
Console.WriteLine(carrot.GetInfo1());
Console.WriteLine("222=" + carrot.Description2());

student Student = new student();
Student.name = "Nurlan";
Student.surname = "Nuruzade";
Student.age = 18;
Student.grade = "A++";
Student.id = "123";
Console.WriteLine(Student.About());
Console.WriteLine(Student.AboutAll());
