using MySql.Data.MySqlClient;
using ProjetoPW.Models;

namespace ProjetoPW.Repository.Contract
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly string _ConexaoMySQL;
        public UsuarioRepository(IConfiguration conf)
        {
            _ConexaoMySQL = conf.GetConnectionString("ConexaoMySQL");
        }

        public void Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuario)
        {
            using (var conexao = new MySqlConnection(_ConexaoMySQL))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("insert into usuario(nomeUsu, Cargo, DataNasc)" +
                                                        "values (@nomeUsu, @Cargo, @DataNasc)", conexao);
                cmd.Parameters.Add("@nomeUsu", MySqlDbType.VarChar).Value = usuario.nomeUsu;
                cmd.Parameters.Add("@Cargo", MySqlDbType.VarChar).Value = usuario.Cargo;
                cmd.Parameters.Add("@DataNasc", MySqlDbType.Date).Value = usuario.DataNasc;

                cmd.ExecuteNonQuery();
                conexao.Close();
            }
        }
            
        public void Excluir(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> ObterTodosUsuarios() //pagina 27 do pdf nilsin
        {
            List<Usuario> UsuarioList = new List<Usuario>();
            using (var conexao = new MySqlCommand("Select * from usuario");
        }

        public Usuario ObterUsuario(int Id)
        {
            throw new NotImplementedException();
        }
    }

}

