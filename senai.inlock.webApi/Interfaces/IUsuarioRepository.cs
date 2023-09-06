using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    /// Interface de usuários
    /// </summary>
    public interface IUsuarioRepository
    {
        /// <summary>
        /// responsável pelo login do usuário
        /// </summary>
        /// <param name="email">e-mail do usuário</param>
        /// <param name="senha">senha do usuário</param>
        /// <returns>Objeto do tipo usuário que foi buscado</returns>
        UsuarioDomain Login(string email, string senha);
    }
}
