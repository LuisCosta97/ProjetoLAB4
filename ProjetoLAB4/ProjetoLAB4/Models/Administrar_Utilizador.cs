using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLAB4.Models
{
    public class Administrar_Utilizador
    {
        [Key]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Administrar Utilizador")]
        public int ID_Adminstrar_Utilizador { set; get; }

        [ForeignKey ("ID_Administrador")]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Administrador")]
        public int ID_Administrador { set; get; }

        [ForeignKey("ID_Utilizador")]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Utilizador")]
        public int ID_Utilizadorr { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Motivo")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Não ultrapassar os limites")]
        public string Motivo { set; get; }

        [Display(Name = "Data inicio")]
        public DateTime data_inicio { get; set; }

        [Display(Name = "Data fim")]
        public DateTime data_fim { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Estado")]
        public int Estado { set; get; }

    }
}
