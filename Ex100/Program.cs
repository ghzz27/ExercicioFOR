

int S = 0;
int Maior = 0;
int Menor = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite um número:");
    int num = int.Parse(Console.ReadLine());

    S += num;

    if (i == 1)
    {
        Maior = num;
        Menor = num;
    }
    else
    {
        if (num > Maior) Maior = num;
        if (num < Menor) Menor = num;
    }
}

Console.WriteLine("Média: " + (S / 10.0));
Console.WriteLine("Maior: " + Maior);
Console.WriteLine("Menor: " + Menor);



