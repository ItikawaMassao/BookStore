using AutoMapper;

namespace Book.Store.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(p =>
            {
                p.AddProfile<DomainToViewModelMappingProfile>();
                p.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}