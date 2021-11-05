using System;

namespace _01
{
    public class Pessoa
    {
        public string nome;

        public int idade;

        public void mensagem()
        {
            Console.WriteLine("Olá "+nome+" você tem "+idade+" anos");
        }
        public void mensagem(string nome, int idade)
        {
            Console.WriteLine("Olá "+nome+" você tem "+idade+" anos");
        }
        
    }
}