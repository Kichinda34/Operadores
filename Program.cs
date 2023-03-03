internal class Program
{
    private static void Main(string[] args)

    {
        int opcao = 0;
        double num1, num2, resultado;

        void Menu()
        {
     
            Console.Clear();
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Dividir");
            Console.WriteLine("4 - Multiplicar");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                default:
                    Console.WriteLine("Opção Inválida!");
                    Console.ReadLine();
                    break;

                case 1:
                    adicao();
                    Console.WriteLine("O resultado da operação é: "+resultado);
                    Console.ReadLine();
                    break;
                case 2:
                    subtracao();
                    Console.WriteLine("O resultado da operação é: " + resultado);
                    Console.ReadLine();
                    break;
                case 3:
                    divisao();
                    Console.WriteLine("O resultado da operação é: " + resultado);
                    Console.ReadLine();
                    break;
                case 4:
                    mult();
                    Console.WriteLine("O resultado da operação é: " + resultado);
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Volte sempre!");
                    break;
            }
        }

        Console.WriteLine("Informe o primeiro numero: ");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo numero: ");
        num2 = double.Parse(Console.ReadLine());

        while (opcao != 5)
        {
            Menu();
        }

        void adicao()
        {
            resultado = num1 + num2;
        }

        void subtracao()
        {
            resultado = num1 - num2;
        }

        void divisao()
        {
            resultado = num1 / num2;
        }

        void mult()
        {
            resultado = num1 * num2;
        }
    }
}