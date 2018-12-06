using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLAB4.Models
{
    public class Recomendacao
    {
        [Key]
        [ForeignKey("ID_Envio")]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Utilizador que envia recomendação")]
        public int ID_Envio { set; get; }

        [Key]
        [ForeignKey("ID_Recepcao")]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Utilizador que recebe recomendação")]
        public int ID_Recepcao { set; get; }

        [Key]
        [Display(Name = "Data da recomendação")]
        public DateTime data_recomendacao { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Estado")]
        public int Estado { set; get; }


    }
}
