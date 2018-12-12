using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLAB4.Models
{
    public class Vinho_Garrafeira
    {

        [Key]
        [ForeignKey("Vinho")]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Vinho")]
        public int ID_Vinho { set; get; }

        [Key]
        [ForeignKey("Garrafeira")]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Garrafeira")]
        public int ID_Garrafeira { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Descrição")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Não ultrapassar os limites")]
        public string Descricao { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Stock")]
        public int stock { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Preço")]
        public float preco { set; get; }




    }
}
