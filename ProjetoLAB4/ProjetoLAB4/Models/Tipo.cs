using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLAB4.Models
{
    public class Tipo
    {
        [Required(ErrorMessage = "Obrigatorio")]
        public int ID { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Produtor")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Não ultrapassar os limites (1-50)")]
        public string TipoNome { set; get; }

    }
}
