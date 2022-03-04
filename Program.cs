using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapelTesouraVDD
{
    class Program
    {
        static void Main(string[] args)
        {
            string jogada1, jogada2;
            bool alguemganhou = false;

            for (int i = 0; i > int.MaxValue; i++)
            {
                Console.WriteLine("jogador 1, informe sua jogada (pedra, papel ou tesoura): ");
                jogada1 = Console.ReadLine();

                Console.WriteLine("jogador 2, informe sua jogada (pedra, papel ou tesoura): ");
                jogada2 = Console.ReadLine();

                if (jogada1 == "pedra" && jogada2 == "tesoura" || jogada1 == "papel" && jogada2 == "pedra" || jogada1 == "tesoura" && jogada2 == "papel")
                {
                    Console.WriteLine("Jogador1 é o ganhador");
                    alguemganhou = true;
                }
                else if (jogada2 == "pedra" && jogada1 == "tesoura" || jogada2 == "papel" && jogada1 == "pedra" || jogada2 == "tesoura" && jogada1 == "papel")
                {
                    Console.WriteLine("Jogador 2 é o ganhador");
                    alguemganhou = true;
                }
                else
                {
                    Console.WriteLine("O jogo ficou empatado, jogue novamente até algúem ganhar");
                }
     
                    if (alguemganhou == true)
                        Console.ReadKey();
                else
                {

                }
   
            }
        }
    }
}
