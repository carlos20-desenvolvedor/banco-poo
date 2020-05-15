using BancoPoo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPOO.Pages.Usuario
{
    public class Register
    {
        public void ShowPage()
        {
            string nome, sobrenome, telefone, email, senha;
                        
            Console.Clear();
            Console.WriteLine("Digite seu Nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu Sobrenome");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Digite seu Telefone");
            telefone = Console.ReadLine();
            Console.WriteLine("Digite seu Email");
            email = Console.ReadLine();
            Console.WriteLine("Digite sua Senha");
            senha = Console.ReadLine();
            
            try
            {
                var cliente = new Cliente(nome, sobrenome, telefone, email, senha);
                Console.WriteLine(cliente.Nome);
                Console.WriteLine(cliente.NomeCompleto);

                var cliente2 = new Cliente(nome, sobrenome);
                Console.WriteLine(cliente2.Nome);
                Console.WriteLine(cliente2.NomeCompleto);
            }
            catch
            {
                Console.WriteLine("Erro de Senha!");
            }
            

        }
    }
}
