using BenchmarkDotNet.Attributes;

namespace InBenchmark
{
    [MinColumn, MaxColumn]
    public class BenchmarkManager
    {
        private readonly List<Item> items = new List<Item>();

        private readonly List<ItemStruct> itemsStruct = new List<ItemStruct>();

        private readonly List<ItemRecord> itemsRecord = new List<ItemRecord>();

        private const int N = 10000;

        public BenchmarkManager()
        {
            for (int i = 0; i < N; i++)
            {
                items.Add(new Item()
                {
                    ItemId = i,
                    Price = 9.99,
                    Author = "George Orwell",
                    Title = "1984",
                    Year = 1949,
                    Stock = 20,
                    Description = @"dystopian social science fiction novel and cautionary tale written by the English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.",
                    Publisher = "Secker & Warburg",
                    Language = "en",
                    Isin = 0
                });

                itemsStruct.Add(new ItemStruct()
                {
                    ItemId = i,
                    Price = 9.99,
                    Author = "George Orwell",
                    Title = "1984",
                    Year = 1949,
                    Stock = 20,
                    Description = @"dystopian social science fiction novel and cautionary tale written by the English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.",
                    Publisher = "Secker & Warburg",
                    Language = "en",
                    Isin = 0
                });

                itemsRecord.Add(new ItemRecord()
                {
                    ItemId = i,
                    Price = 9.99,
                    Author = "George Orwell",
                    Title = "1984",
                    Year = 1949,
                    Stock = 20,
                    Description = @"dystopian social science fiction novel and cautionary tale written by the English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.",
                    Publisher = "Secker & Warburg",
                    Language = "en",
                    Isin = 0
                });
            }
        }

        [Benchmark]
        public void ChangeWithoutInClass()
        {
            foreach (Item item in items)
            {
                ItemChanger.ReturnIsinWithOutIn(item);
            }
        } 

        [Benchmark]
        public void ChangeWithInClass()
        {
            foreach(Item item in items)
            {
                ItemChanger.ReturnIsinWithIn(item);
            }
        }

        [Benchmark]
        public void ChangeWithoutInStruct()
        {
            foreach (ItemStruct item in itemsStruct)
            {
                ItemChanger.ReturnIsinWithoutInStruct(item);
            }
        }

        [Benchmark]
        public void ChangeWithInStruct()
        {
            foreach (ItemStruct item in itemsStruct)
            {
                ItemChanger.ReturnIsinWithInStruct(item);
            }
        }

        [Benchmark]
        public void ChangeWithoutInRecord()
        {
            foreach (ItemRecord item in itemsRecord)
            {
                ItemChanger.ReturnIsinWithoutInRecord(item);
            }
        }

        [Benchmark]
        public void ChangeWithInRecord()
        {
            foreach (ItemRecord item in itemsRecord)
            {
                ItemChanger.ReturnIsinWithInRecord(item);
            }
        }
    }
}
