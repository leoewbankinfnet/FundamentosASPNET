using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TP03_ASP_Leonardo_Ewbank.Models
{
    public class Aniversariantes
    {
       
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public String nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public String sobrenome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public DateTime DataNascimento { get; set; }
    }
    
}
