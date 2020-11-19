using System;

namespace Programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float salario;
            string estado_civil;
            
            do{
                Console.WriteLine("Digite seu Nome:");
                nome = Console.ReadLine();

                Console.WriteLine("Digite sua Idade:");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu Salário:");
                salario = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu Estado Civil: Solteiro, Casado(a), Viuvo, Divorciado(a)");
                estado_civil = (Console.ReadLine());

                if(nome == ""){Console.WriteLine("Defina um nome valido"); nome = "null";}

                if(idade < 0 || idade > 150){ Console.WriteLine("Defina uma idade valido"); idade = 1;}

                if(salario == 0){Console.WriteLine("Defina um salario valido"); salario = 0;}

                if(estado_civil == "Solteiro" || estado_civil == "Casado" || estado_civil == "Viuvo" || estado_civil == "Divorciado"){}
                
                else{
                    Console.WriteLine("Defina um estado civil valido");
                    estado_civil = "";
                }
            }while(nome == "" || idade == 1 || salario == 0 || estado_civil == "" );

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Confirmação de dados:");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salario: " + salario);
            Console.WriteLine("Estado Civil: " + estado_civil);

            Console.WriteLine("Validação concluida");
        }
    }
}
