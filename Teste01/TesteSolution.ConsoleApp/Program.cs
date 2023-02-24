using System;
using TesteSolution.Domain.Entities;

namespace TesteSolution.ConsoleApp
{
    class Program
    {
        const string sair = "N";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("----Classificador de Triangulos----");
            string respo = "";

            while(respo.ToUpper() != sair)
            {
                Triangulo triangulo = new Triangulo();

                Console.WriteLine("- Qual o Tamanho do Lado 1?");
                double Lado_1 = Convert.ToDouble(Console.ReadLine());
                triangulo.lado_1 = Lado_1;

                Console.WriteLine("- Qual o Tamanho do Lado 2?");
                double Lado_2 = Convert.ToDouble(Console.ReadLine());
                triangulo.lado_2 = Lado_2;

                Console.WriteLine("- Qual o Tamanho do Lado 3?");
                double Lado_3 = Convert.ToDouble(Console.ReadLine());
                triangulo.lado_3 = Lado_3;

                if(VerificaLado(triangulo.lado_1,triangulo.lado_2,triangulo.lado_3)is false)
                {
                    Console.WriteLine("Triangulo Inválido");
                    Console.WriteLine("------------------");
                }

                else if (triangulo.lado_1 == triangulo.lado_2 & triangulo.lado_1 == triangulo.lado_3 & triangulo.lado_2 == triangulo.lado_3)
                {
                    Console.WriteLine("Triangulo Equilátero");
                    Console.WriteLine("------------------");
                }

                else if (triangulo.lado_1 == triangulo.lado_2 | triangulo.lado_1 == triangulo.lado_3 | triangulo.lado_2 == triangulo.lado_3)
                {
                    Console.WriteLine("Triangulo Isosceles");
                    Console.WriteLine("-------------------");
                   
                }

                else if (triangulo.lado_1 != triangulo.lado_2 & triangulo.lado_1 != triangulo.lado_3 & triangulo.lado_2 != triangulo.lado_3)
                {
                    Console.WriteLine("Triangulo Escaleno");
                    Console.WriteLine("-------------------");
                   
                }

                Console.WriteLine("Continuar S/N");
                respo = Console.ReadLine();

            }







        }

        public static bool VerificaLado(double Lado_1,double Lado_2,double Lado_3)
        {
            double SomaLados1e2 = Lado_1 + Lado_2;
            double SomaLados1e3  = Lado_1 + Lado_3;
            double SomaLados2e3 = Lado_2 + Lado_3;

            if (SomaLados1e2 < Lado_3 | SomaLados1e3 < Lado_2 | SomaLados2e3 < Lado_1) 
            {
                return false;
            }
            if (Lado_1 == 0 | Lado_2 == 0 | Lado_3 == 0) 
            {
                return false;
            }  
        
            return true;
        }
    }
}
