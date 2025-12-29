// See https://aka.ms/new-console-template for more information

// Print the first 20 Fibonacci numbers
int a = 0, b = 1;
Console.WriteLine(a);
Console.WriteLine(b);

for (int i = 2; i < 20; i++)
{
    int next = a + b;
    Console.WriteLine(next);
    a = b;
    b = next;
}
