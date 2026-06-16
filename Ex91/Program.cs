Console.WriteLine("Hello, World!");
int acm = 0;
for (int i = 85; i <= 907; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
        acm = acm + i;
    }
}
Console.WriteLine("Todos os numeros pares sao entre 85 e 907: " + acm);
