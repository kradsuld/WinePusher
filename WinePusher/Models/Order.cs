using System;

namespace WinePusher.Models
{
    class Order
    {
        public int OrderId { get; set; }
        public int RoundId { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string MemberName { get; set; }
        public string WineName { get; set; }
        public string WineType { get; set; }
        public decimal WinePrice { get; set; }
        public int Bottles { get; set; }
        public decimal OrderAmount { get; set; }
        public string Delivered { get; set; }
        public string Paid { get; set; }
    }
}
