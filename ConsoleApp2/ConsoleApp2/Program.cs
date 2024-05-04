int a = 12;
int b = 34;
int c = 13;
string name = "Javid";
string surname = "Quluzade";
string sentence = "I am Javid";
int[] arr = {100, 200, 300};
int res1 = FindResult(a, b);
int res2 = FindSquare(a);
int arrres = FindArrsum(arr);
string word = Reverse(name);
Console.WriteLine(res1);
Console.WriteLine(res2);
Console.WriteLine(arrres);
HelloMessage(name, surname);
Console.WriteLine(word);
CheckNumber(b);
int res3 = FindPerimetrofSquare(a);
double res4 = FindPerimetrofTriangle(a, b, c);
Console.WriteLine("Perimetr Square " + res3);
Console.WriteLine("Perimtr Triangle " + res4);
int res5 = FindSpace(sentence);
Console.WriteLine($"The number of spaces in sentence is {res5}");
static int FindResult(int num1, int num2)
{
    return num1 * num2;
}
static int FindSquare(int num)
{
    return num * num;
}
static int FindArrsum(int[] arr)
{
    int sum = 0;
    foreach (int i in arr)
    {
        sum += i;
    }
    return sum;
}
static void HelloMessage(string name, string surname)
{
    Console.WriteLine($"Xosh geldin {name} {surname}");
}
static string Reverse(string s)
{
    string reverse = "";
    for (int i = s.Length-1; i >= 0; i--)
    {
        reverse  += s[i];
    }
    return reverse;
}
static void CheckNumber(int num)
{
    if (num %7 == 0)
    {
        Console.WriteLine("eded 7 e bolunur");
    }
    else
    {
        for (int i = num; i > 0; i--)
        {
            if (i %7 == 0)
            {
                Console.WriteLine(i);
                break;

            }
        }
    }
}
// overload
static int FindPerimetrofSquare(int a)
{
    return a * 4;
}
static double FindPerimetrofTriangle(double a, int b, int c)
{
    return a + b + c;
}
static int FindSpace(string sentence)
{
    int spacecount = 0;
    foreach (char c in sentence)
    {
        if (c == ' ')
        {
            spacecount++;
        }
    }
    return spacecount;
}