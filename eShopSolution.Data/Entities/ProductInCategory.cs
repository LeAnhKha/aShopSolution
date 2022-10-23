using System;
using System.Collections.Generic;
using System.Text;

namespace aShopSolution.Data.Entitis
{
    // khóa nhiều nhiều
    public class ProductInCategory // bảng tạo khóa ngoại giữ 2 bảng product và category
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
