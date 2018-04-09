using GalaxyFlow.EntityFrameworkCore;

namespace GalaxyFlow.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly GalaxyFlowDbContext _context;

        public TestDataBuilder(GalaxyFlowDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}