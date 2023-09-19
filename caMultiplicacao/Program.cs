using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caMultiplicacao
{
    internal class Program
    {


        public int Multiplicacao(int x, int y)
        {
            if (y == 1) return x;
            else
                return Multiplicacao(x, y - 1) + x;

        }

        public int Fibonacci(int posicao)
        {
            if (posicao <= 1)
            {
                return 0;
            }
            else if (posicao == 2)
            {
                return 1; 
            }
            else
            {
                return FibonacciRecursivo(0, 1, posicao - 3); 
            }

        }
        public int FibonacciRecursivo(int primeiro,int segundo,int posicao)
        {
            if (posicao == 0)
            {
                return primeiro+segundo;
            }else
                return FibonacciRecursivo(segundo, primeiro+segundo, posicao-1);

        }
        public int BuscaBinaria(int inicio, int final, int target, int[] vetor)
        {
            if (inicio <= final)
            {
                int meio = inicio + (final - inicio) / 2;
                if (vetor[meio] < target)
                {
                    return BuscaBinaria(meio, final, target, vetor);
                }
                else if (vetor[meio] > target)
                {
                    return BuscaBinaria(inicio, meio, target, vetor);
                }
                else
                {
                    return meio;
                }
            }
            return -1;

        }
        public int Maior(int maior, int[] vetor, int count)
        {
            if (vetor.Length == count)
            {
                return maior;
            }
            else
            {
                if (maior <= vetor[count])
                {
                    return Maior(vetor[count], vetor, count + 1);
                }
                else
                {
                    return Maior(maior, vetor, count + 1);
                }

            }

        }
        public int Menor(int menor, int[] vetor, int count)
        {
            if (vetor.Length == count)
            {
                return menor;
            }
            else
            {
                if (menor >= vetor[count])
                {
                    return Menor(vetor[count], vetor, count + 1);
                }
                return Menor(menor, vetor, count + 1);

            }
        }
        public int Soma(int[] vetor,int soma,int count)
        {
            if (vetor.Length == count)
            {
                return soma;
            }
            return Soma(vetor, soma + vetor[count], count + 1);

        }
        public double Media(int[] vetor)
        {
            return Soma(vetor,0,0)/vetor.Length;

        }
        static void Main(string[] args)
        {
            Program program = new Program();


            int resultado1 = program.Multiplicacao(5, 3);
            int resultado2 = program.Multiplicacao(7, 4);
            int resultado3 = program.Multiplicacao(2, 5);

            Console.WriteLine("Resultado 1: " + resultado1);
            Console.WriteLine("Resultado 2: " + resultado2);
            Console.WriteLine("Resultado 3: " + resultado3);

            int fibinacci = program.Fibonacci(7);
            Console.WriteLine(fibinacci);

            Console.ReadLine();

        }
    }
}
