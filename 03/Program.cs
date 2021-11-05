using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa israel = new Pessoa();
            israel.Altura = 1.72;
            israel.Peso = 70;
            israel.yourIMC();
        }
    }
}
