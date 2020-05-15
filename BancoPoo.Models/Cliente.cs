using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BancoPoo.Models
{
    public class Cliente
    {
        public Cliente (string n, string sobrenome, string telefone, string email, string senha)
        {
            Nome = n;
            SobreNome = sobrenome;
            Telefone = telefone;
            Email = email;
            if(ASenhaEValida(senha))
            {
                Senha = senha;
            }
            else
            {
                throw new Exception();
            }
            
            NomeCompleto = $"{n} {sobrenome}";
        }
        public Cliente (string nome, string sobrenome)
        {
            Nome = nome;
            SobreNome = sobrenome;
            NomeCompleto = $"{nome} {sobrenome}";
        }
        public string Nome { get; private set; }
        public string SobreNome { get; private set; }

        public string NomeCompleto { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        //private bool ASenhaEValida(string senha) => return senha.Length <= 10;
        private Boolean ASenhaEValida(string senha)
        {
            if (senha.Length >= 10 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
