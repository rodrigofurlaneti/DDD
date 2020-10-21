using DDD.Domian.Entities;
using System.ComponentModel.DataAnnotations;
namespace DDD.MVC.ViewModels
{
    public class Client_ProductViewModel
    {
        [Key]
        public int Client_ProductId { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
    }
}