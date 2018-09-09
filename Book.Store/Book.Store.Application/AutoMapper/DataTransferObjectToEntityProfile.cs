using AutoMapper;
using Book.Store.Domain.DTO;
using Book.Store.Domain.Entities;

namespace Book.Store.Application.AutoMapper
{
    public class DataTransferObjectToEntityProfile : Profile
    {
        public DataTransferObjectToEntityProfile()
        {
            CreateMap<LivroDTO, BsLivro>();
        }
    }
}