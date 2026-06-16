Console.WriteLine("Hello, World!");
int soma = 0;
int num = 0;
int contNegativo = 0;

for(int i = 1;i <= 5; i++)
{
    Console.WriteLine("Digite um numero");
    
    num = int.Parse(Console.ReadLine());
    if(num >= 0)
    {
        soma = soma + num; //aculadora
    }
    else
    {
        contNegativo++; //Contando de 1 em 1
    }
    
}

Console.WriteLine($"A soma dos numeros positivos {soma}");
Console.WriteLine($"A quantidade de numeros negativos {contNegativo}");



