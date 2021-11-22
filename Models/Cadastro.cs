using System.ComponentModel.DataAnnotations;

namespace AllTechCoreWeb.Models
{
    public class Cadastro
    {
        public int ID { get; set; }
        [Required( ErrorMessage ="Informe o nome")]
        [MaxLength(50, ErrorMessage ="O tamanho máximo é de 50 caracteres")]
        public string Nome { get; set; }
        [Required( ErrorMessage ="Informe o e-mail")]
        public string Email { get; set; }
    }
}
