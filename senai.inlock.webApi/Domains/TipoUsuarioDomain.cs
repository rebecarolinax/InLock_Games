using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade (tabela) de tipos de usuário
    /// </summary>
    public class TipoUsuarioDomain
    {
        public int IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        //refere-se a permissão do usuário
        public string? Titulo { get; set; }
    }
}
