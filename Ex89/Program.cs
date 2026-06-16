Console.WriteLine("Hello, World!");
int acm = 0;
int num = 0;
int contNegativo = 0;

for(int i = 1;i <= 5; i++)
{
    Console.WriteLine("Digite um numero");
    
    num = int.Parse(Console.ReadLine());
    if(num >= 0)
    {
        acm = acm + num;
    }
    else
    {
        contNegativo++;
    }
    
}

Console.WriteLine($"A soma dos numeros positivos {acm}");
Console.WriteLine($"A soma dos numeros negativos {contNegativo}");



