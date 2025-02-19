static string[] KlitatMachrozot()
{
    string str, temp;
    string[] strsEzer = new string[100];

    int index = 0;
    Console.WriteLine("enter str");
    str = Console.ReadLine();
    while (str != "END" && index < 100)
    {
        if (Takinut(str))
           strsEzer[index++] = str.ToLower();
        Console.WriteLine("enter str");
        str = Console.ReadLine();
    }
    string[] strs = new string[index];
    int mikum;
    for (int i = 0; i < index - 1; i++)
    {
        for (int j = i + 1; j < index; j++)
        {
            mikum = 0;
            while (mikum < strsEzer[i].Length && mikum < strsEzer[j].Length && strsEzer[i][mikum] == strsEzer[j][mikum])
                   mikum++;
            if (mikum == strsEzer[i].Length || mikum == strsEzer[j].Length)
            {
                if (strsEzer[i].Length> strsEzer[j].Length)
                {
                    temp = strsEzer[i];
                    strsEzer[i] = strsEzer[j];
                    strsEzer[j] = temp;
                }
            }
            else if(strsEzer[i][mikum] > strsEzer[j][mikum])
            {
                temp = strsEzer[i];
                strsEzer[i] = strsEzer[j];
                strsEzer[j] = temp;
            }
        }
    }
    for (int i = 0; i < index; i++)
        strs[i] = strsEzer[i];
    return strs;
}
static bool Takinut(string str)
{
    if (str.Length > 15)
        return false;
    for (int i = 0; i < str.Length; i++)
        if (str[i] < 'A' || str[i] > 'Z' && str[i] < 'a' || str[i] > 'z')
           return false;
    return true;
}
//main
string[] strs=KlitatMachrozot();
int s =0,sMax=0,line=0,lineMax=0;
for (int i = 0; i < strs.Length-1; i++)
{
    if (strs[i][0] == strs[i + 1][0])
    {
         Console.Write(strs[i]+", ");
         s++;
    }
    else
    {
        line++;
        Console.Write(strs[i] +", the number of the words taht they start with: " + strs[i][0]+", is: "+s+1);
        if (s>sMax)
        {
            sMax = s;
            lineMax=line;
        }
        s = 0;
        Console.WriteLine();
    }
}
Console.Write("the line with the most words is: "+lineMax);


//Console.WriteLine(Convert.ToChar('z'+1));//המרה לchar
