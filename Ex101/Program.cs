Console.WriteLine("Digite um número:");
int n = int.Parse(Console.ReadLine());

int acm = 1;

for (int i = 1; i <= n; i++)
{
    acm *= i;
}

Console.WriteLine("Fatorial: " + acm);

