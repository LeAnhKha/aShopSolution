using aShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace aShopSolution.Data.Entitis
{
    public class Order
    {
        public int Id { set; get; }
        public DateTime OrderDate { set; get; }
        public Guid UserId { set; get; }
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public string ShipEmail { set; get; }
        public string ShipPhoneNumber { set; get; }
        public OrderStatus Status { set; get; }

        // quan hệ 1 nhiều

        // sẻ có 1 list nhiều oderDetai  
        public List<OrderDetail> OrderDetails { get; set; }// thuộc tính trỏ tới bảng orderDetail
    }
}
