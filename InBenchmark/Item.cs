using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InBenchmark
{
    public class Item
    {
        public long ItemId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }
        
        public double Price { get; set; }

        public int Stock { get; set; }

        public string Publisher { get; set; }

        public string Language { get; set; }

        public int Year { get; set; }
        
        public string Description { get; set; }

        public int Isin { get; set; }
    }
}
