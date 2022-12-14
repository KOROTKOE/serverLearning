using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopLearning.Data.Models
{
    public class Car
    {
        public int id { set; get; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool isFavorite { get; set; }
        public bool available { set; get; }
        public int categoryID { set; get; }
        public virtual Category Category { get; set; }
    }
}
