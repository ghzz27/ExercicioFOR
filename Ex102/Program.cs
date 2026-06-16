double totalHotel = 0;

for (int i = 1; i <= 30; i++)
{
    Console.WriteLine("Digite o nome do cliente:");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite o número de diárias:");
    int diarias = int.Parse(Console.ReadLine());

    double taxa;

    if (diarias < 15)
        taxa = 4.00;
    else if (diarias == 15)
        taxa = 3.60;
    else
        taxa = 3.00;

    double totalCliente = (50 + taxa) * diarias;
    totalHotel += totalCliente;

    Console.WriteLine("Cliente: " + nome);
    Console.WriteLine("Total da conta: R$ " + totalCliente);
}

