using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Models
{
    public class BubbleModel
    {
        public string Month { get; set; }
        public Count Count { get; set; }
    }

    public class Count
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }
    }
}
