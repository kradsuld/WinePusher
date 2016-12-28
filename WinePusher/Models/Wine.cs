using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinePusher.Models
{
    class Wine
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Store { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}