using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09correcao21
{
    class Program
    {
        static void Main(string[] args)
        {
            int pontos = 0;
            Random sorteador = new Random();

            Console.WriteLine("Bem-VAINDO AO JOGO 21");
            Console.WriteLine("Seu objetivo é chgar proximo de 21 pomtos");
            while(true)
            {
                
                
                Console.WriteLine($"Voce tem {pontos} pontos");
                Console.Write("Deseja continuar? 1 para sim ou 2 para nao:");
                int opcao = int.Parse(Console.ReadLine());

                if(opcao == 2)
                {
                    Console.WriteLine("-FIM DE JOGO-");
                    break;
                }
                int numero = sorteador.Next(1, 11);
                Console.WriteLine($"Voce tirou o numero {numero}");

                pontos = numero + pontos;

                if(pontos>21)
                {
                    Console.WriteLine("!!!VOCE PERDEU!!!\n");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
