using AutoMapper;
using Book.Store.Domain.DTO;
using Book.Store.MVC.ViewModels.Livros;

namespace Book.Store.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<LivroViewModel, LivroDTO>();
        }
    }
}