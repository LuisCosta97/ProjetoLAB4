using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLAB4.Models
{
    public class Utilizador
    {
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Username")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Não ultrapassar os limites")]
        public string Username { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Password")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Não ultrapassar os limites")]
        public string Password { set; get; }

        [EmailAddress]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Email")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Não ultrapassar os limites")]
        public string Email { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Nome")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Não ultrapassar os limites")]
        public string Nome { set; get; }

        [Key]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Utilizador")]
        public int ID_Utilizador { set; get; }

        [ForeignKey ("ID_Morada")]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Morada do Utilizador")]
        public int ID_Morada { set; get; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Estado")]
        public int Estado { set; get; }
    }
}
