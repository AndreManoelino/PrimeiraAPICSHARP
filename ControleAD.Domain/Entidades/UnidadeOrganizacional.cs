using System;
using System.Collections.Generic;

namespace ControleAD.Domain.Entidades
{
    public class UnidadeOrganizacional
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Caminho { get; private set; }

        public List<Usuario> Usuarios { get; private set; }
        public List<Grupo> Grupos { get; private set; }

        protected UnidadeOrganizacional()
        {
            Usuarios = new List<Usuario>();
            Grupos = new List<Grupo>();
        }

        public UnidadeOrganizacional(string nome, string caminho)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Caminho = caminho;
            Usuarios = new List<Usuario>();
            Grupos = new List<Grupo>();
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            if (!Usuarios.Contains(usuario))
            {
                Usuarios.Add(usuario);
            }
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
