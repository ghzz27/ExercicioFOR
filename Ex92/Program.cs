Console.WriteLine("Hello, World!");
Console.WriteLine("Digite N:");
int n = int.Parse(Console.ReadLine());

double A = 0;

for (int i = 1; i <= n; i++)
{
    A += (double)(n - i + 1) / i;
}

Console.WriteLine(A);
