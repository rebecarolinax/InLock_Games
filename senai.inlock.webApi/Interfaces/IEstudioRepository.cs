using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    /// Interface de estúdios
    /// </summary>
    public interface IEstudioRepository
    {
        /// <summary>
        /// Lista todos os estúdios com suas respectivas listas de jogos
        /// </summary>
        /// <returns>Uma lista de estúdios com seus jogos</returns>
        List<EstudioDomain> ListarComJogos();
    }
}
