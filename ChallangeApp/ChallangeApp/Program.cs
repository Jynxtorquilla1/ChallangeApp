int number = 48590009;
string nuberAsString = number.ToString();
char[] signs = nuberAsString.ToArray();
List<int> nums = new List<int> (Enumerable.Range(0, 10));

for (int i = 0; i<=9; i++) 
{
    nums[i] = 0;
}

foreach (char sign in signs)
{
    if (sign == '0')
    {
        nums[0]++;        
    }
    else if (sign == '1')
    {
        nums[1]++;
    }
    else if (sign == '2')
    {
        nums[2]++;
    }
    else if (sign == '3')
    {
        nums[3]++;
    }
    else if (sign == '4')
    {
        nums[4]++;
    }
    else if (sign == '5')
    {
        nums[5]++;
    }
    else if (sign == '6')
    {
        nums[6]++;
    }
    else if (sign == '7')
    {
        nums[7]++;
    }
    else if (sign == '8')
    {
        nums[8]++;
    }
    else if (sign == '9')
    {
        nums[9]++;
    }
}
Console.WriteLine("Number:" + number);
Console.WriteLine ("Digit   " + "    Counter");

for (int i = 0; i<10 ; i++)
{
    Console.WriteLine(i + "     =>      " + nums[i]);
}