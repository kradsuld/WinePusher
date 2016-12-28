using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinePusher.Models
{
    class RoundListItem
    {
        public int RoundId { get; set; }
        public Nullable<System.DateTime> RoundDate { get; set; }
        public string WineType { get; set; }
        public string WineName { get; set; }
        public string Store { get; set; }
        public Nullable<decimal> WinePrice { get; set; }
        public int OrdersCount { get; set; }
        public string RoundStatus { get; set; }
    }
}
