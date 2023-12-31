﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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
    }
    public enum Tipo
    {
        Receita,
        Despesa
    }
}