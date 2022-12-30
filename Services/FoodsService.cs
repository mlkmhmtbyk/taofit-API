using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using taofitAPI.Data.Models;

namespace taofitAPI.Services
{
    public class FoodsService
    {
        private readonly DataContext _context;
        
        public FoodsService(DataContext context)
        {
            _context = context;
        }

        public List<Food> GetFoods()
        {
            return _context.Foods.ToList();
        }

        public void AddFood(Food food)
        {
            var _food = new Food()
            {
                FoodName = food.FoodName,
                Amount = food.Amount,
                Calory = food.Calory
            };

            _context.Foods.Add(_food);
            _context.SaveChanges();
        }
    }
}