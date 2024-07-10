using AutoMapper;

namespace ObjectMapping
{
    public static class AutoMapper 
    {
        public static AnimalDto Map(AnimalEntity animalEntity)
        {
            return AutoMapperConfig.Mapper.Map<AnimalDto>(animalEntity);
        }
    }

    public static class AutoMapperConfig
    {
        private static readonly Lazy<IMapper> LazyMapper = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AnimalEntity, AnimalDto>().ReverseMap()
                // Map only the properties you need. You can use ForMember to ignore properties that are not needed.
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.AnimalIdent, opt => opt.MapFrom(src => src.AnimalIdent));

                // Avoid unnecessary mappings
                cfg.CreateMap<AnimalEntity, AnimalDto>()
                   .ForMember(dest => dest.DateofBirth, opt => opt.Ignore())// Ignoring unnecessary property
                   .ForMember(dest => dest.Id, opt => opt.Ignore());

            });

            config.CompileMappings();
            return config.CreateMapper();
        });

        public static IMapper Mapper => LazyMapper.Value;
    }
}
