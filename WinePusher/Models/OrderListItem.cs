using System;

namespace WinePusher.Models
{
    class OrderListItem
    {
        public int OrderId { get; set; }
        public string MemberName { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string WineName { get; set; }
        public decimal TotalAmount { get; set; }
        public string Delivered { get; set; }
        public string Paid { get; set; }
    }
}
