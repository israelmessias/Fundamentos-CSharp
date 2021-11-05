using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa israel = new Pessoa();
            israel.setAltura(1.72);
            israel.setPeso(69);
            israel.yourIMC();
        }
    }
}
