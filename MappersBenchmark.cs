using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMapping
{
    public class MappersBenchmark
    {
        AnimalEntity AnimalEntity = new AnimalEntity();

        [GlobalSetup]
        public void Setup()
        {
            AnimalEntity.Id = 1;
            AnimalEntity.Name = "Product";
            AnimalEntity.AnimalIdent = "S100";
            AnimalEntity.DateofBirth = DateTime.Now;
            
        }

        [Benchmark]
        public void TestManualMapper()
        {
            AnimalDto productDto = ManualMapper.Map(AnimalEntity);
        }

        [Benchmark]
        public void TestMapperlyMapper()
        {
            AnimalDto productDto = MapperlyMapper.ProductEntityToProductDto(AnimalEntity);
        }

        [Benchmark]
        public void TestMapsterMapper()
        {
            AnimalDto productDto = MapsterMapper.Map(AnimalEntity);
        }

        [Benchmark]
        public void TestAutoMapper()
        {
            AnimalDto productDto = AutoMapper.Map(AnimalEntity);
        }

    }
}
