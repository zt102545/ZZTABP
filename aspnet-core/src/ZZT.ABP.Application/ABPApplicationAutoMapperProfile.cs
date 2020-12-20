using AutoMapper;

namespace ZZT.ABP
{
    public class ABPApplicationAutoMapperProfile : Profile
    {
        public ABPApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();
        }
    }
}
