using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    public class ViewModels
    {

    }
    public class ItemCategory
    {
        public ItemCategory(int id, string category)
        {
            Id = id;
            Category = category;
        }
        public int Id { get; set; }
        public string Category { get; set; }
    }
    public class Items
    {
        public Items(int id, int category, string name, int price)
        {
            Id = id;
            Category = category;
            Name = name;
            Price = price;
        }
        public int Id { get; set; }
        public int Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
