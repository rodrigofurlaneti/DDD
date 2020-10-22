using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DDD.MVC.ViewModels
{
    public class ClientViewModel
    {
        [Key]
        public int ClientId { get; set; }
        
        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(10, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Email")]
        public string Email { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime RegistrationDate { get; set; }
        
        [DisplayName("Ativo")]
        public bool Active { get; set; }
    }
}