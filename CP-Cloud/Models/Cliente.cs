using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace CP_Cloud.Models
{
    [Table("TB_CPS_CLIENTE")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string Sobrenome { get; set; }

        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string DataNasc { get; set; }

        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string Senha { get; set; }

        [DisplayName("Endereço")]
        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string Endereco { get; set; }
    }
}
