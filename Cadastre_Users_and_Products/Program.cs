
using Cadastre_User_and_Products;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

public class Project
{

    static void Main(string[] args)
    {


        // Criando uma Instância da classe User
        User user = new User();

        // Definindo valores para as propriedades do usuário
        Console.WriteLine("Digite seu nome: ");
        user.Name = Console.ReadLine();


        Console.WriteLine($"Seu ID é: {user.Id}");


        Console.WriteLine("Informe a sua idade: ");
        string? AgeString = Console.ReadLine();
        string? ageString = AgeString;
        user.Agestring = ageString;


        Console.WriteLine("Digite seu E-mail: ");
        user.Email = Console.ReadLine();


        Console.WriteLine("Usuário Ativo?");
        user.active = true;
        Console.WriteLine($"{user.active}");
    }
}




