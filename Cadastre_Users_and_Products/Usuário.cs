
using Cadastre_User_and_Products;
using System;
using System.Collections.Generic;
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

        List<User> users = new List<User>();
        int contador = 0;
        
        while (contador < 2){

            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"{users[i].Name} Cadastrado com Sucesso");
                Console.WriteLine("-------------------------------");

            }

            Console.WriteLine("Digite seu nome: ");
            user.Name = Console.ReadLine();
            // Validando o Nome do Usuário
            if (user.Name == null || user.Name.Length <= 1) 
            {
                Console.WriteLine("Nome Inválido!");
                break;
            }

            // Validando a idade 
            Console.WriteLine("Informe a sua idade: ");
           string? ageString = Console.ReadLine();
            if (int.TryParse(ageString, out int age))
            {
                user.Age = age; // Armazena a idade como inteiro em user.Age
                if (user.Age < 18)
                {
                    Console.WriteLine("Menor de idade. Não cadastrado.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Certifique-se de que o valor digitado é um número por favor,");
                break;
            }
            
            //Validando o E-mail
            Console.WriteLine("Digite seu E-mail: ");
            user.Email = Console.ReadLine();
            if (user.Email == null || user.Email.Length == 0)
            {
                Console.WriteLine("Email Inválido!");
                break;
            }

            //Analisando atividade do Usuário
            Console.WriteLine("Usuário Ativo?");
            user.active = true;
            if (user.active == false)
            {
                Console.WriteLine("Usuário Inativo. Não cadastrado.");
                break;
            };
            Console.WriteLine($"Seu ID é: {user.Id}");

            

            users.Add(user);
            // Contagem de pessoas toda vez que todo o código for executado 
            // Só para quando a quantidade de pessoas pedidas forem excedidas
            contador++;



        }

        for (int i = 0; i < users.Count; i++)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"{users[i].Name} Cadastrado com Sucesso");
            Console.WriteLine("-------------------------------");

        }
    }
}

