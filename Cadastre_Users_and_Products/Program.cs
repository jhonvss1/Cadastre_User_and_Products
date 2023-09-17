
using Cadastre_User_and_Products;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Security.Cryptography;

public class Project
{

    static void Main(string[] args)
    {

        

        // Criando uma Instância da classe User
        User user = new User();

        // Definindo valores para as propriedades do usuário
        int contador = 0;

        while (contador < 6){

        Console.WriteLine("Digite seu nome: ");
        user.Name = Console.ReadLine();
        // Validando o Nome do Usuário
            if (user.Name == null || user.Name.Length <= 1) {
                Console.WriteLine("Nome Inválido!");
                break;
            }


            Console.WriteLine("Informe a sua idade: ");
            string? AgeString = Console.ReadLine();
            string? ageString = AgeString;
            user.Agestring = ageString;


            Console.WriteLine("Digite seu E-mail: ");
            user.Email = Console.ReadLine();
            if (user.Email == null || user.Email.Length == 0)
            {
                Console.WriteLine("Email Inválido!");
                break;
            }

            Console.WriteLine("Usuário Ativo?");
            user.active = true;
            if (user.active == false ) 
            {
                Console.WriteLine("Usuário Inativo. Não cadastrado.");
                break;
            };
            Console.WriteLine($"{user.active}");

            Console.WriteLine($"Seu ID é: {user.Id}");

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Usuário Cadastrado com sucesso");
            Console.WriteLine("-------------------------------");
            contador++;
        }
    }
}