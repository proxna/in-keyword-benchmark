using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InBenchmark
{
    public static class ItemChanger
    {
        public static int ReturnIsinWithOutIn(Item item)
        {
            return item.Isin;
        }

        public static int ReturnIsinWithIn(in Item item)
        {
            return item.Isin;
        }

        public static int ReturnIsinWithoutInStruct(ItemStruct itemStruct)
        {
            return itemStruct.Isin;
        }

        public static int ReturnIsinWithInStruct(in ItemStruct itemStruct)
        {
            return itemStruct.Isin;
        }

        public static int ReturnIsinWithoutInRecord(ItemRecord itemRecord)
        {
            return itemRecord.Isin;
        }

        public static int ReturnIsinWithInRecord(in ItemRecord itemRecord)
        {
            return itemRecord.Isin;
        }
    }
}
