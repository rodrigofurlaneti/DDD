using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace DDD.MVC.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        [DisplayName("Valor")]
        public decimal Value { get; set; }

        [DisplayName("Disponivel")]
        public bool Available { get; set; }
    }
}