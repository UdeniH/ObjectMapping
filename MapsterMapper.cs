using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMapping
{
    public static class MapsterMapper
    {
        public static AnimalDto Map(AnimalEntity animalEntity)
        {
            return TypeAdapter.Adapt<AnimalEntity, AnimalDto>(animalEntity);
        }
    }
}
