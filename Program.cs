using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Digite o número");
            float numero1 = float.Parse(Console.ReadLine());

        
            Console.WriteLine("Digite o Operador");
            string operador = Console.ReadLine();

            Console.WriteLine("Digite o numero");
            float numero2 = float.Parse(Console.ReadLine());

            float resultado = 0;
   
            switch(operador)
            {
                case "+": resultado = numero1 + numero2; break;
                case "-": resultado = numero1 - numero2; break;
                case "*": resultado = numero1 * numero2; break;
                case "/": resultado = numero1 / numero2; break;
                default: Console.WriteLine("O operador não foi identificado"); break;
            }

            Console.Clear();
            Console.WriteLine("Resultado: {0}", resultado);
            Console.WriteLine("");

            Continuar:
            Console.WriteLine("1- Para continuar    Outro-Sair");
            string opcao = Console.ReadLine();
            
            if (opcao == "1")
            {

                Console.WriteLine("Numero do calculo anterior = {0}", resultado);
                Console.WriteLine("Digite o Operador");
                operador = Console.ReadLine();

                Console.WriteLine("Digite o Numero");
                numero2 = float.Parse(Console.ReadLine());

               
                switch (operador)
                {

                    case "+": resultado = resultado + numero2; break;
                    case "-": resultado = resultado - numero2; break;
                    case "*": resultado = resultado * numero2; break;
                    case "/": resultado = resultado / numero2; break;
                    default: Console.WriteLine("O operador não foi identificado"); break;
                }

                Console.WriteLine("Novo Resultado {0}", resultado);

                goto Continuar;

            }
            else {
            
            }

            
         }
    }
}
