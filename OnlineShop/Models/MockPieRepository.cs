using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class MockPieRepository: IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> Pies
        {
            get
            {
                return new List<Pie>
                {
                    new Pie {PieId = 1, Name="Strawberry Pie", Price=15.95M, ShortDescription },
                    new Pie {PieId = 1, Name="Strawberry Pie", Price=15.95M, ShortDescription },
                    new Pie {PieId = 1, Name="Strawberry Pie", Price=15.95M, ShortDescription },
                    new Pie {PieId = 1, Name="Strawberry Pie", Price=15.95M, ShortDescription },

                };
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            throw new System.NotImplementedException();
        }
    }
}
