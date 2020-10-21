using AutoMapper;
using DDD.Domian.Entities;
using DDD.MVC.ViewModels;
namespace DDD.MVC.AutoMapper
{
    public class DomainToViewModelIMappingProfile : Profile
    {
        public override string ProfileName 
        { 
            get { return "ViewModelToDomainMappings"; } 
        }
        protected override void Configure()
        {
            Mapper.CreateMap<ClientViewModel, Client>();
            Mapper.CreateMap<ProductViewModel, Product>();
            Mapper.CreateMap<Client_ProductViewModel, Client_Product>();
        }
    }
}