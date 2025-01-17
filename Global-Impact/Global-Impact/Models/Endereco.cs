﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Global_Impact.Models
{
    [Table("Tb_Endereco")]
    public class Endereco
    {
        public int EnderecoId { get; set; }

        [MinLength(9, ErrorMessage = "O cep deve ter 8 caracteres.")]
        [MaxLength(9, ErrorMessage = "O cep deve ter 8 caracteres.")]
        [Display(Name = "CEP"), Required(ErrorMessage = "Informe o cep.")]
        public string Cep { get; set; }

        [MinLength(4, ErrorMessage = "O nome do bairro precisa ter, no mínimo, 4 caracteres.")]
        [MaxLength(30, ErrorMessage = "O nome do bairro precisa ter, no máximo, 30 caracteres.")]
        [Display(Name = "Bairro"), Required(ErrorMessage = "Informe o bairro.")]
        public string Bairro { get; set; }

        [MinLength(4, ErrorMessage = "O nome da cidade precisa ter, no mínimo, 4 caracteres.")]
        [MaxLength(30, ErrorMessage = "O nome da cidade precisa ter, no máximo, 30 caracteres.")]
        [Display(Name = "Cidade"), Required(ErrorMessage = "Informe a cidade.")]
        public string Cidade { get; set; }

        [MinLength(2, ErrorMessage = "O UF precisa ter 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "O UF precisa ter 2 caracteres.")]
        [Required(ErrorMessage = "Informe a UF.")]
        public string UF { get; set; }

        [MinLength(5, ErrorMessage = "O nome do Logradouro deve ter, no mínimo, 5 caracteres.")]
        [MaxLength(40, ErrorMessage = "O nome do Logradouro precisa ter, no máximo, 40 caracteres.")]
        [Display(Name = "Logradouro"), Required(ErrorMessage = "Informe o Logradouro.")]
        public string Logradouro { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "Informe o número.")]
        [MinLength(2, ErrorMessage = "Deve ter, no mínimo, 2 números.")]
        [MaxLength(5)]
        public string Numero { get; set; }

        [Display(Name = "Complemento")]
        [MaxLength(30)]
        public string Complemento { get; set; }

    }
}
