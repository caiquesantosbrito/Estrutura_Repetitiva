using System;

namespace Programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            string senha = "";

            while(true){
                Console.WriteLine("Digite seu nome:");
                nome= Console.ReadLine();

                Console.WriteLine("Digite sua senha:");
                senha = Console.ReadLine();

                if(nome == senha){
                    Console.WriteLine("Você não pode usar a mesma palavra para nome e senha!");
                }else{break;}
            }
            Console.WriteLine("Bem vindo "+ nome +"!");
        }
    }
}
