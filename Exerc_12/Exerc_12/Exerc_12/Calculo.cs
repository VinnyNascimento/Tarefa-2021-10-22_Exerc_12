using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_12
{
    class Calculo
    {
        #region atributos
        private double num1;
        private double num2;
        private double num3;
        private double resultado1;
        private double resultado2;
        private double resultado3;
        #endregion

        #region construtores
        public Calculo()
        {
            this.num1 = 0;
            this.num2 = 0;
            this.num3 = 0;
        }

        public Calculo(double num1, double num2, double num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
        #endregion

        #region métodos de interface (Setter's & Getter's)
        public void setNum1(double num1)
        {
            this.num1 = num1;
        }

        public void setNum2(double num2)
        {
            this.num2 = num2;
        }
        public void setNum3(double num3)
        {
            this.num3 = num3;
        }

        public double getNum1()
        {
            return this.num1;
        }

        public double getNum2()
        {
            return this.num2;
        }
        public double getNum3()
        {
            return this.num3;
        }

        public double getResultado1()
        {
            return this.resultado1;
        }
        public double getResultado2()
        {
            return this.resultado2;
        }
        public double getResultado3()
        {
            return this.resultado3;
        }
        #endregion

        #region métodos funcionais
        public void calcular()
        {
            this.resultado1 = (this.num1 + this.num2);
            this.resultado2 = (this.num2 + this.num3);
            this.resultado3 = (this.num1 + this.num3);

            if (this.resultado1 < this.num3)
            {
                if (this.resultado2 < this.num1)
                {
                    if (this.resultado3 < this.num2)
                    {
                        Console.WriteLine("Os valores inseridos não formam um triângulo");
                    }
                }
            }

            if (this.num1 == this.num2 && this.num2 != this.num3 || this.num1 == this.num3 && this.num3 != this.num2 || this.num2 == this.num3 && this.num3 != this.num1)
            {
                Console.Write("Os valores inseridos são de um triângulo isósceles");
            }
            if (this.num1 == this.num2 && this.num2 == this.num3)
            {
                Console.Write("Os valores inseridos são de um triângulo equilátero");
            }

            if (this.num1 != this.num2 && this.num2 != this.num3 && this.num1 != this.num3)
            {
                Console.Write("Os valores inseridos são de um triângulo escaleno");
            }
        }
    
        #endregion
    }
}
