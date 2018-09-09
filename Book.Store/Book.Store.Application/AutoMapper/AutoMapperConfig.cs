using AutoMapper;

namespace Book.Store.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DataTransferObjectToEntityProfile>();
                x.AddProfile<EntityToDataTransferObjectProfile>();
            });
        }
    }
}