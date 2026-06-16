Console.WriteLine("Digite a quantidade de funcionários:");
int qtd = int.Parse(Console.ReadLine());

double soma = 0;
double maior = 0;
double menor = 0;

for (int i = 1; i <= qtd; i++)
{
    Console.WriteLine("Digite o nome:");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite o salário:");
    double salario = double.Parse(Console.ReadLine());

    soma += salario;

    if (i == 1)
    {
        maior = salario;
        menor = salario;
    }
    else
    {
        if (salario > maior) maior = salario;
        if (salario < menor) menor = salario;
    }
}

Console.WriteLine("Média: " + (soma / qtd));
Console.WriteLine("Maior salário: " + maior);
Console.WriteLine("Menor salário: " + menor);


