using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLAB4.Models
{
    public class Comentario
    {
        [Key]
        [Display(Name = "Data do comentário")]
        public DateTime data_comentario { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Texto do Comentário")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Não ultrapassar os limites")]
        public string Texto { set; get; }

        [Key] 
        [ForeignKey("Cliente")]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Utilizador")]
        public virtual int ID_Cliente { set; get; }
        public virtual Utilizador Cliente { set; get; }

        [Key]
        [ForeignKey("ID_Vinho")]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Vinho")]
        public virtual int ID_Vinho { set; get; }
        //public virtual Vinho Vinho { set; get; }

        




    }
}
