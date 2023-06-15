


string str = "ABC";

string strsmall = "abc";


for (int i = 0; i < str.Length; i++)
{
    Console.Write(str[i]);
    Console.Write(str[i] - 'A');

    int idx = (str[i] - 'A');

    Console.WriteLine();
}


string str2 = "1012";


for (int i = 0; i < str2.Length; i++)
{
    Console.Write(str2[i]);
    Console.Write( (int)(str2[i] - '0'));
    
    Console.WriteLine();
}
int ivalue = 1234;
string strValue = ivalue.ToString();
Console.WriteLine( int.Parse(str2) ) ;


string str3 = "AABBCCDDEE";

string sub = str3.Substring(0, 3);
Console.WriteLine(sub);

str3 = str3 + "Back";
Console.WriteLine(str3);
str3 =  "Front" + str3;
Console.WriteLine(str3);

// 위치 찾기.
Console.WriteLine(str3.IndexOf("AA"));

Console.WriteLine(str3.StartsWith("Front"));

Console.WriteLine(str3.EndsWith("Back"));
