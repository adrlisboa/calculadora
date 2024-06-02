using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }

        static void Main(string[] args)
        {

            bool escolheuSair = false;
            while (!escolheuSair) // Enquanto o usuário NÃO(!) ESCOLHER SAIR, EXIBA O MENU
            {
                // Exiba o menu
                Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções: ");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raíz\n7-Sair");

                /*
                string opcaoTXT = Console.ReadLine();
                int opcaoInt = int.Parse(opcaoTXT);
                Menu opcao = (Menu)opcaoInt;
                MESMA COISA \/
                */

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }

                Console.Clear();
            }
            //Feche

        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

    }
}
