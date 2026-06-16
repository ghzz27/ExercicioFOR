
int acm = 0;
for (int i = 1; i <= 64; i = i * 2)
{
    Console.WriteLine(i);
    acm = acm + i;
}
Console.WriteLine("O total de grãos que o monge recebeu: " + acm);