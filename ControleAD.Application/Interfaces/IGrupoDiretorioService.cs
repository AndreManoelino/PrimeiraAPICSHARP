using ControleAD.Domain.Entidades;
using System.Collections.Generic;

namespace ControleAD.Application.Interfaces
{
    public interface IGrupoDiretorioService
    {
        IEnumerable<Grupo> ObterTodos();
    }
}
