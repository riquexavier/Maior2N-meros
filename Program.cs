Console.Clear();

int NumberOne;
int NumberTwo;

Console.Write("Digite um número: ");
NumberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite outro número: ");
NumberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
if (NumberOne > NumberTwo)
{
    Console.WriteLine($"{NumberOne} é o maior número");
}
else
{
    Console.WriteLine($"{NumberTwo} é o maior número");
}
