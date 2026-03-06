using ProjetoPW.Models;

namespace ProjetoPW.Repository.Contract
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> ObterTodosUsuarios();

        void Cadastrar(Usuario usuario);

        void Atualizar(Usuario usuario);

        Usuario ObterUsuario(int Id);

        void Excluir(int Id);
    }
}
