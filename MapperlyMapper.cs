using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMapping
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public static partial class MapperlyMapper
    {
        public static partial AnimalDto ProductEntityToProductDto(AnimalEntity animalEntity);
        
    }
}
