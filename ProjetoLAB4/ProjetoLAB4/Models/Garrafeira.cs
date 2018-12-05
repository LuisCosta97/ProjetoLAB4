using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLAB4.Models
{
    public class Garrafeira
    {
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Contacto")]
        public int ID_Contacto { set; get; }

        [Key]
        [ForeignKey ("ID_Utilizador")]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Utilizador")]
        public int ID_Utilizador { set; get; }

    }
}
