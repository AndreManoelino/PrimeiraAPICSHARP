using System;
using System.Collections.Generic;

namespace ControleAD.Domain.Entidades
{
    public class Usuario
    {
        public Guid Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public string Login { get; private set; }
        public string Email { get; private set; }
        public bool Ativo { get; private set; }

        public List<Grupo> Grupos { get; private set; }

        protected Usuario()
        {
            Grupos = new List<Grupo>();
        }

        public Usuario(string nomeCompleto, string login, string email)
        {
            Id = Guid.NewGuid();
            NomeCompleto = nomeCompleto;
            Login = login;
            Email = email;
            Ativo = true;
            Grupos = new List<Grupo>();
        }

        public void Desativar()
        {
            Ativo = false;
        }

        public void AdicionarGrupo(Grupo grupo)
        {
            if (!Grupos.Contains(grupo))
            {
                Grupos.Add(grupo);
            }
        }
    }
}
