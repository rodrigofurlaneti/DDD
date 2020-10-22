using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace DDD.MVC.ViewModels
{
    public class ClientProductViewModel
    {
        [Key]
        public int ClientProductId { get; set; }
        [DisplayName("Cliente")]
        public int ClientId { get; set; }
        [DisplayName("Produto")]
        public int ProductId { get; set; }
        public virtual ClientViewModel Clients { get; set; }
        public virtual ProductViewModel Products { get; set; }

    }
}