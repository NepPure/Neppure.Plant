using Neppure.Plant.EntityFrameworkCore;

namespace Neppure.Plant.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly PlantDbContext _context;

        public TestDataBuilder(PlantDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}