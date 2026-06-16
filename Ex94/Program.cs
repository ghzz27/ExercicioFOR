
int acm = 0;
int a, b;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite o valor de A: ");
    a = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor de B: ");
    b = int.Parse(Console.ReadLine());

    Console.WriteLine($"O resto da divisão de A por B é de: {a % b}");

    for (i = 0; i <= 0; i++)
    {
        Console.WriteLine("Nao repete");
    }

    int x = 0;
    while (x <= 100)
    {
        for (x = 0; x <= 100; x++)
        {
            Console.WriteLine(x);
        }
    }

    Console.WriteLine("Quantas vezes vai repetir ?");
    int num = int.Parse(Console.ReadLine());
    Console.Clear();
    for (i = 1; i <= num; i++)
    {
        Console.WriteLine(i);
    }



}


