using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2023.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Antes de prosseguir, preencha este campo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Antes de prosseguir, preencha este campo")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Antes de prosseguir, preencha este campo")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Antes de prosseguir, preencha este campo")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }

        public ICollection<Consumo> Consumos { get; set; }

    }
}
