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

        [Required(ErrorMessage = "Obrigatorio para consulta")]
        [Display(Name = "Descrição")]
        public string Descricao { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Fotografia")]
        public string Caminho_Foto { set; get; }

        [Key] 
        [ForeignKey ("ID_Utilizador")]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Utilizador")]
        public int ID_Utilizador { set; get; }

    }
}
