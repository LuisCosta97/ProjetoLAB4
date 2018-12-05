using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLAB4.Models
{
    public class Vinho_Garrafeira
    {
        [Required(ErrorMessage = "Obrigatorio")]
        public int ID { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Regiao")]
        public int ID_Regiao { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Tipo")]
        public int ID_Tipo { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Teor Alcoolico")]
        public float Teor_Alcoolico { set; get; }
        
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Fotografia")]
        public string Caminho_Fotografia { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Ano")]
        public int Ano { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Categoria")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Não ultrapassar os limites (1-50)")]
        public string Categoria { set; get; }

    }
}
