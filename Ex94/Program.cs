
int acm = 0;
int a, b;

for (int i = 1; i <= 10; i++) // repetir 10 vezes
{
    Console.WriteLine("Digite o valor de A: ");
    a = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor de B: ");
    b = int.Parse(Console.ReadLine());

    Console.WriteLine($"O resto da divisão de A por B é de: {a % b}");
}

    for (int i = 0; i <= 0; i++)
    {
        Console.WriteLine("Nao repete"); //nao roda
        Console.WriteLine("Digite o valor de A: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de B: ");
        b = int.Parse(Console.ReadLine());

    }

    for (int i = 1; i <2; i++)
    {
        for (int x = 0; x <= 50; x++)   /////50 em uma 50 em  outra
        {
            Console.WriteLine("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"O resto da divisão de A por B é de: {a % b}");

        }
    }

    Console.WriteLine("Quantas vezes vai repetir ?"); //Perguntar quanto vai repetir 
    int num = int.Parse(Console.ReadLine());
    
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine(i);
    }

    




