using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        int n1, n2;
        Console.WriteLine("Insira dois numeros: ");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("O valor da soma de: " + n1 +" + " + n2 + " = " +(n1 + n2));
        Console.WriteLine("O valor da subtração de: " + n1 + " - " + n2 + " = " + (n1 - n2));
        Console.WriteLine("O valor da multiplicação de: " + n1 + " * " + n2 + " = " + (n1 * n2));
        
        if (n1 == 0)
        {
            Console.WriteLine("Não é possível divisão por 0");
        }
        else
        {
            Console.WriteLine("O valor da divisão de: " + n1 + " / " + n2 + " = " + (n1 / n2));
        }
    }
}