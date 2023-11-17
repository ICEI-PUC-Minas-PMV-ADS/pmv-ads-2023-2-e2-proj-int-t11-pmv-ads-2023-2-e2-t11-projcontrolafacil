using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2023.Models
{
    [Table("Transacoes")]
    public class Transacao
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o tipo.")]
        public Tipo Tipo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor.")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data.")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a descrição.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Usuário")]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
    public enum Tipo
    {
        Receita,
        Despesa
    }
}