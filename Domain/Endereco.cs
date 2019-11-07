using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        public int enderecoid { get; set; }

        [Display (Name ="CEP:")]
        public string cep { get; set; }

        [Display (Name ="Rua:")]
        public string logradouro { get; set; }

        [Display (Name ="Bairro")]
        public string bairro { get; set; }

        [Display (Name ="Cidade:")]
        public string localidade { get; set; }

        [Display (Name ="UF:")]
        public string uf { get; set; }

    }
}
