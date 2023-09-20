
using Cadastre_User_and_Products;
using Cadastre_Users_and_Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Security.Cryptography;

      
    List<User> users = new List<User>();
    List<Product> products = new List<Product>();

        int contador = 0;
        
        while (contador < 5){


        // Instanciando a User
            User user = new User();

            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"{users[i].Name} Cadastrado com Sucesso");
                Console.WriteLine("-------------------------------");

            }

            Console.WriteLine("Digite seu nome: ");
            user.Name = Console.ReadLine();
        // Validando o Nome do Usuário
            if (string.IsNullOrEmpty(user.Name))
            {
                Console.WriteLine("Nome Inválido!");
                return;
            }

        // Validando a idade 
            Console.WriteLine("Informe a sua idade: ");
            int age = Convert.ToInt32(Console.ReadLine());
            user.Age = age;

            if (user.Age < 18) 
            { 
                Console.WriteLine("Menor de idade. Inválido");
                return;
            }

        //Validando o E-mail
            Console.WriteLine("Digite seu E-mail: ");
            user.Email = Console.ReadLine();
            if (string.IsNullOrEmpty(user.Email))
            {
                Console.WriteLine("Email Inválido!");
                return;
            }

        //Analisando atividade do Usuário
            Console.WriteLine("Usuário Ativo");
            user.active = true;
           
        //Atribuindo o Id ao Usuário
            user.Id = contador;
           
        // Recebendo os dados dos usuários e colocando na lista Users
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
        int contador_product = 0;
        while (contador_product < 5)
        {
        //Instanciando a classe Product
            Product product = new Product();

        // Coletando os dados dos produtos
            Console.WriteLine("Nome do produto: ");
            product.NameProduct = Console.ReadLine();

            Console.WriteLine("ID do Produto:");
            product.IdProduct = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{product.NameProduct} Preço: ");
            product.PriceProduct =Convert.ToDecimal (Console.ReadLine());

            Console.WriteLine("ID do usuário associado ao produto: ");
            int userId = Convert.ToInt32(Console.ReadLine());

        //Associando o produto ao usuário correto
            if(users.Exists(u => u.Id == userId))

        // Recebendo as inf do produto e adicionando a lista de produtos
            products.Add(product);

         contador_product++;
        }
        for(int p = 0; p < products.Count; p++)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"O produto {products[p].NameProduct} Cadastrado com Sucesso pelo usuário {products[p].IdUser} que é ?");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"");
        }
