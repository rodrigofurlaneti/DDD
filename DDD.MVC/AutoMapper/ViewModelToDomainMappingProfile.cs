using AutoMapper;
using DDD.Domian.Entities;
using DDD.MVC.ViewModels;
namespace DDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName 
        { 
            get { return "DomainToViewModelMappings"; } 
        }
        protected override void Configure()
        {
            Mapper.CreateMap<Client, ClientViewModel>();
            Mapper.CreateMap<Product, ProductViewModel>();
            Mapper.CreateMap<ClientProduct, ClientProductViewModel>();
        }
    }
}