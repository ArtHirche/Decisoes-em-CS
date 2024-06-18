public class Program
{
    public static void Main(string[] args)
    {
        int numero = 10;
    if (numero > 5)
    {
        Console.WriteLine("O número é maior que 5.");
    }
    else
    {
        Console.WriteLine("O número é menor ou igual a 5.");
    }

    int diaDaSemana = 3;
    switch (diaDaSemana)
    {
        case 1:
            Console.WriteLine("Segunda-feira");
            break;
        case 2:
            Console.WriteLine("Terça-feira");
            break;
        case 3:
            Console.WriteLine("Quarta-feira");
            break;
        case 4:
            Console.WriteLine("Quinta-feira");
            break;
        case 5:
            Console.WriteLine("Sexta-feira");
            break;
        case 6:
            Console.WriteLine("Sábado");
            break;
        case 7:
            Console.WriteLine("Domingo");
            break;
        // Adicione mais casos conforme necessário
        default:
            Console.WriteLine("Dia inválido");
            break;
    }

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Valor de i: {i}");
    }

    int contador = 0;
    while (contador < 5)
    {
        Console.WriteLine($"Contador: {contador}");
        contador++;
    }

    int valor = 0;
    do
    {
        Console.WriteLine($"Valor: {valor}");
        valor++;
    }
    while (valor < 5);

    string[] nomes = { "Thiago", "João", "Rita" };
    foreach (string nome in nomes)
    {
        Console.WriteLine(nome);
    }

    }

}