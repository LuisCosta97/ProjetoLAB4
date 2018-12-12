using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLAB4.Models
{
    public class Administrador
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

        [Key]
        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Administrador")]
        public int ID_Administrador { set; get; }
    }
}
