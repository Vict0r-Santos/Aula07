using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Jogos
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            do
            {
                Console.WriteLine("Valor de i: {0}", i);
                i++;
            } while (i < 10);

            Console.ReadLine();

            /*// Programação orientada a objetos
            Random sorteador = new Random();
            int number = sorteador.Next(1, 10);
            Console.WriteLine("Bem vindo ao jogo de 21");
            Console.WriteLine("");


            Console.ReadKey();*/

        }

        void AtividadeSorteio(){

            // Programação orientada a objetos
            Random sorteador = new Random();
            int numero;
            int sorteio = sorteador.Next(1, 11);


            Console.WriteLine("Bem vindo a Blaze");
            Console.WriteLine("Adivinhe o número entre 1 e 10");
            numero = int.Parse(Console.ReadLine());

            if (numero > 10 || numero < 1)
            {

                Console.WriteLine("Digite um numero valido... baka >_<\n\n\n\n");
                Main(null);
                return;
            }
            if (numero == sorteio)
            {
                Console.WriteLine($"Parabéns, você acertou o numero {sorteio}\n\n");
                Main(null);
                return;
            }

            Console.WriteLine($"Você perdeu... o numero era {sorteio}");
            Main(null);
            return;


            Console.ReadKey();

        }
    }
}
