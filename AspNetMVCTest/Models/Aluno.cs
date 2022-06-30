using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMVCTest.Models
{
    public class Aluno
    {
        /* Data Annotations:
         * Required: Campo requerido, precisa passar. Caso não passe, não irá dar certo
         * 
         * 
         * 
         * 
         */


        public int Id { get; set; }

        [DisplayName("Nome completo")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        public string Nome { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        [EmailAddress(ErrorMessage = "Email em formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é requerido")]
        public string CPF { get; set; }

        public DateTime DataMatricula { get; set; }

        public bool Ativo { get; set; }

        [Required(ErrorMessage = "O campo {0} é requerido")]
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage = "As senhas não conferem")]
        public string SenhaConfirmacao { get; set; }



    }
}