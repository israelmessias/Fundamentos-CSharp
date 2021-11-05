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

        public string Nome
        {
            get{return nome;}
            set{nome=value;}
        }
        public double Nota1
        {
            get{return nota1;}
            set{nota1=value;}
        }

        public double Nota2 
        {
            get{return nota2;}
            set{nota2=value;}
        }
    }
}