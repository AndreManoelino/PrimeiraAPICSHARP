using System;
using System.Collections.Generic;
using ControleAD.Domain.Entidades;

namespace ControleAD.Application.Interfaces
{
    public interface IUnidadeOrganizacionalService
    {
        List<UnidadeOrganizacional> ObterTodas();
        UnidadeOrganizacional ObterPorId(Guid id);
        List<string> ListarUnidadesOrganizacionais();

        void Criar(string nome);
    }
}
