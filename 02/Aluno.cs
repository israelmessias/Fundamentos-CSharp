using System;

namespace _02
{
    public class Aluno
    {
        private string nome;
        private double nota1, nota2;

        private double mediaDoAluno()
        {
            return (this.nota1+this.nota2)/2;
        }

        public string situacaoAluno(double media)
        {
            return media >=7 ? "Aprovado":"Reprovado";
        }

        public void mensagem()
        {
             double mediaAluno = mediaDoAluno();
             string situacao = situacaoAluno(mediaAluno);

            Console.Write("Sua media é: "+mediaAluno+"\nAluno "+situacao);
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }
        public void setNota1(double nota1)
        {
            this.nota1 = nota1;
        }

        public double getNota1()
        {
            return this.nota1;
        }

        public void setNota2(double nota2)
        {
            this.nota2 = nota2;
        }

        public double getNota2()
        {
            return this.nota2;
        }

    }
}