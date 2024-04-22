Console.WriteLine("--- Verificação de Número Primo ---\n");

int numero, num_aux;

//Entrada de dados e Operações
Console.WriteLine("Somente digite números POSITIVOS e DIFERENTES de ZERO\n");

do
{
    Console.Write("Insira um número: ");
    numero = int.Parse(Console.ReadLine());
    num_aux = numero;

    if (num_aux < 0 || num_aux == 0)
    {
        Console.WriteLine("\nResposta Inválida!");
        Console.WriteLine("Digite novamente!\n");
    }

} while (numero < 0 || num_aux == 0);

for (int i = 1; i <= num_aux; i++)
{
    if (num_aux / i == num_aux && num_aux / i != 1)
    {
        if (num_aux % (i + 1) == 0)
        {
            Console.WriteLine("Não é primo");
            i = num_aux;
        }
        else
        {
            if (num_aux % (i + 2) == 0 && num_aux != 3)
            {
                Console.WriteLine("Não é primo");
                i = num_aux;
            }
            else
            {
                if (num_aux % (i + 4) == 0 && num_aux != 5)
                {
                    Console.WriteLine("Não é primo");
                    i = num_aux;
                }
                else
                {
                    if (num_aux % (i + 6) == 0 && num_aux != 7)
                    {
                        Console.WriteLine("Não é primo");
                        i = num_aux;
                    }
                    else
                    {
                        Console.WriteLine("É primo");
                        i = num_aux;
                    }
                }
            }
        }
    }
    else
    {
        Console.WriteLine("É primo");
        Console.WriteLine(i);
        i = num_aux;
    }
}
//Final do programa
Console.WriteLine("\nAperte ENTER para encerrar ...");
Console.ReadKey();