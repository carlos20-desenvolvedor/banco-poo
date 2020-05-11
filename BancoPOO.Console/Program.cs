using System;
using BancoPOO.Pages.Usuario;
namespace BancoPOO.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bem vindo!");
            //System.Console.Write("Gostaria de abrir uma conta? (Sim / Nao)");
            //string resultado = System.Console.ReadLine();

            bool opcaoinvalida = true;
            while (opcaoinvalida == true)
            {
                System.Console.Write("Gostaria de abrir uma conta? (Sim / Nao)");
                string resultado = System.Console.ReadLine();

                if (resultado.ToLower() == "Sim".ToLower())
                {
                    opcaoinvalida = false;
                    var register = new Register();
                }
                else if (resultado.ToLower() == "Nao".ToLower())
                {
                    opcaoinvalida = false;
                    var login = new Login();
                }
                else
                {
                    opcaoinvalida = true;
                }
            }

            
        }
    }
}
