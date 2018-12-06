using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLAB4.Models
{
    public class Contacto
    {
        [ForeignKey("Garrafeira")]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Garrafeira")]
        public int ID_Garrafeira { set; get; }

        [Key]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Contacto")]
        public int ID{ set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Telefone")]
        public int Telefone { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Telefone_fixo")]
        public int Telefone_fixo { set; get; }


    }
}
