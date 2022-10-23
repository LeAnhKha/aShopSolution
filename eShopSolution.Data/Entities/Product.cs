using System;
using System.Collections.Generic;
using System.Text;

namespace aShopSolution.Data.Entitis
{
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DataCreated { set; get; }

        public string SeoAlias { set; get; }


        // thuộc tính liên kết giữa bản product và catrgory / khóa nhiều nhiều
        public List<ProductInCategory> productInCategories { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public List<Cart> Carts { get; set; }

        public List<ProductTranslation> ProductTranslations { get; set; }
    }
}
