using System;
using System.Collections.Generic;

namespace ControleAD.Domain.Entidades
{
    public class Grupo
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public List<Usuario> Usuarios { get; private set; }

        protected Grupo()
        {
            Usuarios = new List<Usuario>();
        }

        public Grupo(string nome, string descricao)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Descricao = descricao;
            Usuarios = new List<Usuario>();
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            if (!Usuarios.Contains(usuario))
            {
                Usuarios.Add(usuario);
                usuario.AdicionarGrupo(this);
            }
        }
    }
}
