using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroiVsMonstro
{
    class Program
    {
        static void Main(string[] args)
        {
            int monstro = 10;
            int heroi = 10;

            Console.WriteLine($"Vida do Monstro = {monstro}");
            Console.WriteLine($"Vida do Heroi = {heroi}");
            Console.WriteLine("||=== INICIO DO JOGO ===||");


            do
            {
                Random aleat = new Random();
                int atak = aleat.Next(1, 10);
                monstro -= atak;
                Console.WriteLine("||=== MONSTRO ===||");
                Console.WriteLine($"DANO: {atak}");
                Console.WriteLine($"VIDA: {monstro}");
                Console.WriteLine("||=============||");

                if (monstro <= 0) continue;

                atak = aleat.Next(1, 10);
                heroi -= atak;
                Console.WriteLine("||=== HEROI ===||");
                Console.WriteLine($"DANO: {atak}");
                Console.WriteLine($"VIDA: {heroi}");
                Console.WriteLine("||=============||");
                if(monstro <= 0 || heroi <= 0)
                {
                    Console.WriteLine("||=== FIM DO JOGO ===||");
                }
                else
                {
                    Console.WriteLine("||=== NOVO ATAQUE ===||");
                }
                

            } while (monstro > 0 && heroi > 0);

            Console.WriteLine(monstro > heroi ? "Monstro ganhou" : "Heroi ganhou");
            Console.ReadLine();

        }
    }
}
