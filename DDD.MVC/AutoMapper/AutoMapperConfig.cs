using AutoMapper;

namespace DDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x => { x.AddProfile<DomainToViewModelIMappingProfile>(); 
                                     x.AddProfile<ViewModelToDomainMappingProfile>(); });
        }
    }
}