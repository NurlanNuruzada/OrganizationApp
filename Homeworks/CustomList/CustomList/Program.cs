using CustomList.Collections;
//MyList<string> ListInt = new MyList<string>();
MyList<int> ListInt = new MyList<int>();
//ListInt.Add("asds");
//ListInt.Add("adsf");
//ListInt.Add("dasfasd");
//ListInt.Add("jtyy");
//ListInt.Add("3q5r");
//ListInt.Add("eutrw");
//ListInt.Add("shjyd");
ListInt.Add(1);
ListInt.Add(6);
ListInt.Add(3);
ListInt.Add(9);
ListInt.Sort();
//ListInt.Clear();
foreach (int item in ListInt)
    Console.WriteLine(item);
