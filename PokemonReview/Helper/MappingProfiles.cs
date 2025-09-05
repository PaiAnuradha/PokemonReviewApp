using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;
namespace PokemonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>().ReverseMap();
            CreateMap<Category, CategoryDto>();
            CreateMap<Review, ReviewDto>();
            CreateMap<Reviewer, ReviewerDto>();
            CreateMap<Owner, OwnerDto>();
            CreateMap<Country, CountryDto>();
        }
    }
}
