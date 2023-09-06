using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi.Repositories
{
    /// <summary>
    /// Classe responsável pelo repositório dos usuários
    /// </summary>
    public class UsuarioRepository : IUsuarioRepository
    {
        //inicia-se a lógica de conexão ao banco de dados
        private string stringConexao = "Data Source = NOTE09-S14; Initial Catalog = inlock_games; User Id = sa; Pwd = Senai@134";
        public UsuarioDomain Login(string email, string senha)
        {
            //definida a conexão
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                //definida a execução do banco de dados
                string queryLogin = "SELECT Usuario WHERE Email = @email AND Senha = @senha";

                using (SqlCommand cmd = new SqlCommand(queryLogin, con))
                {
                    //definido os valores dos parâmetros
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    //aberta a conexão com banco de dados
                    con.Open();

                    //executado o comando e armazenado os dados no rdr
                    SqlDataReader rdr = cmd.ExecuteReader();

                    //se obtido os dados:
                    if (rdr.Read())
                    {
                        //criado objeto Domain
                        UsuarioDomain usuarioEncontrado = new UsuarioDomain()
                        {
                            //atribuída os valores das propriedades do banco de dados
                            IdUsuario = Convert.ToInt32(rdr["idUsuario"]),
                            Email = rdr["email"].ToString(),
                            IdTipoUsuario = Convert.ToInt32(rdr["idTipoUsuario"]),

                                 //criada instância do objeto herdado
                                 TipoUsuario = new TipoUsuarioDomain()
                                 {
                                     Titulo= rdr["titulo"].ToString()
                                 }
                        };
                            //retorna o usuário buscado
                            return usuarioEncontrado;
                    }
                        //caso não encontre um e-mail e senha correspondente, retorna null
                        return null;
                }
            }
        }
    }
}
