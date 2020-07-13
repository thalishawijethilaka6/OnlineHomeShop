using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HomeShop.API.Dtos;
using HomeShop.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace HomeShop.API.Data.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public CategoryRepository(DataContext dataContext, IMapper mapper)
        {
            _mapper = mapper;
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<CategoryForDetailDto>> GetCategory()
        {
          //  var Categories = await _dataContext.Categories.Include(p => p.Products).ToListAsync();    
            
            var Categories = await  (from category in _dataContext.Categories join
                                 product in _dataContext.Products on  category.CategoryID equals product.CategoryId 
                                    join photo in _dataContext.Photos on product.Id equals photo.ProductId 
                                    where photo.IsMain == true 
                                    select new CategoryForDetailDto()
                                    {
                                        CategotyId = category.CategoryID,
                                        CategoryName = category.Name                                   
                                        
                                    }).Distinct().ToListAsync();
                                    
                        return Categories;
        }

     

        
    } 
}