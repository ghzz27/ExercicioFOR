Console.WriteLine("Digite a massa inicial:");
double M = double.Parse(Console.ReadLine());

int T = 0;

for (; M >= 0.05;)
{
    M /= 2;
    T += 50;
}

Console.WriteLine("Tempo necessário: " + T + " segundos");
