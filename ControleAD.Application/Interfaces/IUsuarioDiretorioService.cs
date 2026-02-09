using ControleAD.Domain.Entidades;

namespace ControleAD.Application.Interfaces
{
	public interface IUsuarioDiretorioService
	{
		Usuario CriarUsuario(Usuario usuario);

		Usuario? ObterUsuarioPorLogin(string login);
		IEnumerable<Usuario> ListarUsuarios();

		void DesativarUsuario(Guid usuarioId);

	}
}		