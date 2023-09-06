namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade (tabela) de jogos
    /// </summary>
    public class JogoDomain
    {
        public int IdJogo { get; set; }
        public string? NomeJogo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataLancamento { get; set; }

        //ferramenta usada em C# do Banco de Dados(SmallMoney)
        public Decimal Valor { get; set; }
        public int IdEstudio { get; set; }

        //refere-se a entidade de estúdios que será herdada em jogos
        public  EstudioDomain? Estudio { get; set; }
    }
}
