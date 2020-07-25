using HomeShop.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeShop.API.Data.BrandRepository
{
    public class BrandRepository : IBrandRepository
    {
        private readonly DataContext _context;
        public BrandRepository(DataContext context)
        {
            _context = context;
        }

        /// <summary>Gets the brands.</summary>
        /// <returns></returns>
        public async Task<IEnumerable<Brand>> GetBrands()
        {
            var getBrands = await _context.Brands.Include(p => p.Products).ToListAsync();
            return getBrands;
        }
    }
}