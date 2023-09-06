using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade (tabela) de usuários 
    /// </summary>
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }

        //define que o campo é obrigatório
        [Required(ErrorMessage = "Informe o e-mail!")]
        public string? Email { get; set; }

        //define que o campo é obrigatório
        [Required(ErrorMessage = "Informe a senha!")]
        //define a quantidade de caracteres da senha
        [StringLength(100, MinimumLength = 5, ErrorMessage = "A senha deve conter 5 caracteres!")]
        public string? Senha { get; set; }
        public int IdTipoUsuario { get; set; }
        
        //refere-se a entidade de tipos de usuário que será herdada em usuários
        public TipoUsuarioDomain? TipoUsuario { get; set; }
    }
}
