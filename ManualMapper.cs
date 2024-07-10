using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMapping
{
    public class ManualMapper
    {
        public static AnimalDto Map(AnimalEntity animalEntity)
        {
            return new AnimalDto
            {
                Name = animalEntity.Name,
                AnimalIdent = animalEntity.AnimalIdent,
                DateofBirth = animalEntity.DateofBirth,
            };
        }

    }
}
