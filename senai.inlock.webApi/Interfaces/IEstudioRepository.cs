using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    public interface IEstudioRepository
    {
        void Cadastrar(EstudioDomain novoEstudio);
        List<EstudioDomain> ListarTodos();
        void Deletar(int id);
    }
}
