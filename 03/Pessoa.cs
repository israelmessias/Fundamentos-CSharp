using System;

namespace _03
{
    public class Pessoa
    {
        private double altura;
        private double peso;

        private double calculoIMC(double altura, double peso)
        {
            double imc = peso/(altura*altura);
            return Math.Round(imc, 2);
        }

        public void yourIMC()
        {
            double imc = calculoIMC(this.altura, this.peso);

                if(imc <= 18.5)
                {
                    Console.WriteLine(imc+" Abaixo do peso.");
                }

                else if (imc > 18.5 || imc <= 25)
                {
                    Console.WriteLine(imc+" Peso normal");
                }
                
                else if (imc > 25 || imc <= 30)
                { 
                    Console.WriteLine(imc+" Acima do peso");
                }
  
                else if(imc > 30 || imc <= 35)
                {
                    Console.WriteLine(imc+" Obesidade I");
                }    

                else if (imc > 35 || imc <= 40)
                {
                    Console.WriteLine(imc+" Obesidade II");
                }

               else
                {
                    Console.WriteLine(imc+" Obesidade III");
                }

            }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public double getAltura()
        {
            return this.altura;
        }

        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        public double getPeso(double peso)
        {
            return this.peso;
        }
            // return null;
        }
    }
