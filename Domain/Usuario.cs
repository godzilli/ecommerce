using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Usuarios")]
    public class Usuario
    {

        public Usuario()
        {
            Endereco = new Endereco();
        }
        
        [Key]
        public int usuarioid { get; set; }

        [Display(Name ="E-Mail:")]
        [Required(ErrorMessage ="Campo Obrigatório!")]
        [EmailAddress]
        public string email { get; set; }

        [Display(Name = "Senha:")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string senha { get; set; }

        [Display(Name = "Confirmação de Senha:")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Compare("Senha", ErrorMessage ="Os campos não coincidem!")]
        [NotMapped] //nao é feita uma coluna no banco ou geração de codigo automatica
        public string confsenha { get; set; }

        [Display(Name = "Endereço:")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public Endereco Endereco { get; set; }
    }
}
