using System;

namespace Programa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            do{
            Console.WriteLine("Digite um número entre 0 e 10:");
                nota = int.Parse(Console.ReadLine());

                if(nota <0 || nota >10){
                    Console.WriteLine("Algarismo inválido!");
                }
        }   
            while(nota <0 || nota >10);
            Console.WriteLine("Algorismo valido!");
        }
    }
}
