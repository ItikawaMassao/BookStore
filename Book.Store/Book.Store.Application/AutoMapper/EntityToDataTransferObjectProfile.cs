using AutoMapper;
using Book.Store.Domain.DTO;
using Book.Store.Domain.Entities;

namespace Book.Store.Application.AutoMapper
{
    public class EntityToDataTransferObjectProfile : Profile
    {
        public EntityToDataTransferObjectProfile()
        {
            CreateMap<BsLivro, LivroDTO>();
        }
    }
}