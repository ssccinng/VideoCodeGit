// See https://aka.ms/new-console-tesmplate for more information

string a = null;

string? c = String.Empty;

c = a;
Test("");
Test(c);
Test(a);
Test(null);
Test(null!);

return;

void Test(string b)
{
    Console.WriteLine(b);
}

void Test1(string? b)
{
    
    Console.WriteLine(b.Length);
    b ??= string.Empty;
    Console.WriteLine(b.Length);
}

