using System;

namespace Exerc_12
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declarações & instâncias
            Calculo s;
            s = new Calculo();
            #endregion

            #region Introducao
            Console.Write("Descubra se esses valores formam um Triângulo");
            Console.ReadLine();
            #endregion

            #region entrada
            Console.Write("Informe o 1° Numero: ");
            s.setNum1(double.Parse(Console.ReadLine()));

            Console.Write("Informe o 2° Numero: ");
            s.setNum2(double.Parse(Console.ReadLine()));

            Console.Write("Informe o 3° Numero: ");
            s.setNum3(double.Parse(Console.ReadLine()));
            #endregion

            #region processo
            s.calcular();
            #endregion

            #region saída
            /*Console.WriteLine("Os valores informados foram: {0}, {1} e {2}", s.getNum1(), s.getNum2(), s.getNum3());*/
            #endregion
        }
    }
}