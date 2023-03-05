//burada bosluq bosluqa berar olur
//ancaq bir mudedden sonra bosluq stringi hemin space + " " e berabar olmur
//bundan sonra ise biz hemin indexden baslayarag wordu toplayirig
string CusStringTrim(string word)
{
    string TestWord = "";
    string SpaceString = "";
    string Result = "";
    for (int i = 0; i < word.Length; i++)
    {
        for (int j = word.Length; j >=0 ; j--)
        {

        }
        TestWord += word[i];
        SpaceString += " ";
        if (TestWord == SpaceString)
        {
            continue;
        }
        Result += word[i];
    }
    return Result;
}

