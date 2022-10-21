using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InBenchmark
{
    public struct ItemStruct
    {
        public long ItemId { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        public long BookshelfId { get; set; }

        public long ImageId { get; set; }

        public int Year { get; set; }

        public int Isin { get; set; }
    }
}
