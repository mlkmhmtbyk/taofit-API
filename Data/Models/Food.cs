using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taofitAPI.Data.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string Amount { get; set; }
        public int Calory { get; set; }
    }
}