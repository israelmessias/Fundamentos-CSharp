using System;
using _01;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome="João";
            p1.idade=35;
            p1.mensagem();

            Console.WriteLine("\n\t-------###-------\n");

            Pessoa p2 = new Pessoa();
            p2.mensagem("Roberto", 17);
        }
    }
}
