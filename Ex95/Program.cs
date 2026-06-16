Console.WriteLine("Hello, World!");
double somaIdade = 0;
int qtdMenorAlt = 0;

double somaAltura = 0;
int qtdMaioresD20 = 0;

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("Digite a idade:");
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a altura:");
    double altura = double.Parse(Console.ReadLine());

    if (altura < 1.70)
    {
        somaIdade += idade;
        qtdMenorAlt++;
    }

    if (idade > 20)
    {
        somaAltura += altura;
        qtdMaioresD20++;
    }
}
   
Console.WriteLine("Idade média: " + (somaIdade / qtdMenorAlt));
Console.WriteLine("Altura média: " + (somaAltura / qtdMaioresD20));


