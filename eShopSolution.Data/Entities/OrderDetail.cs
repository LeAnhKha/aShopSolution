using System;
using System.Collections.Generic;
using System.Text;

namespace aShopSolution.Data.Entitis
{
    public class OrderDetail
    {
        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }


        // quan hệ 1 nhiều

        // sẽ có 1 thuộc tính trỏ tới bảng Oder
        public Order Orders { get; set; } // trỏ tới bảng Order

        public Product Product { get; set; } // trỏ tới bảng product


    }
}
