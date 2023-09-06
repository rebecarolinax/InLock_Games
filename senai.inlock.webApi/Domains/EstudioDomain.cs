namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade (tabela) de estúdios
    /// </summary>
    public class EstudioDomain
    {
        public int IdEstudio { get; set; }
        public string? NomeEstudio { get; set; }

        //refere-se a listagem de jogos
        public List<JogoDomain>? ListaJogos {get; set;}
    }
}
