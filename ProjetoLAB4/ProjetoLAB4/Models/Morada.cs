using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLAB4.Models
{
    public class Morada
    {
        [Key]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Morada")]
        public int ID_Morada { set; get; }

        
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Rua")]
        [StringLength(40, MinimumLength = 1, ErrorMessage = "Não ultrapassar os limites")]
        public string Rua { set; get; }

  
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Cidade")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Não ultrapassar os limites")]
        public string Cidade { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Codigo Postal")]
        public int Codigo_Postal { set; get; }



    }
}
