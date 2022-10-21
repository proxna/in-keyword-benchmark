using BenchmarkDotNet.Attributes;

namespace InBenchmark
{
    [MinColumn, MaxColumn]
    public class BenchmarkManager
    {
        private readonly Random _random = new Random();

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
                    ItemId = _random.NextInt64(),
                    BookshelfId = _random.NextInt64(),
                    ImageId = _random.NextInt64(),
                    Isin = _random.Next(),
                });

                itemsStruct.Add(new ItemStruct()
                {
                    ItemId = _random.NextInt64(),
                    BookshelfId = _random.NextInt64(),
                    ImageId = _random.NextInt64(),
                    Isin = _random.Next(),
                });

                itemsRecord.Add(new ItemRecord()
                {
                    ItemId = _random.NextInt64(),
                    BookshelfId = _random.NextInt64(),
                    ImageId = _random.NextInt64(),
                    Isin = _random.Next(),
                });
            }
        }

        [Benchmark]
        public void ChangeWithoutInClass()
        {
            int sum = 0;
            foreach (Item item in items)
            {
                sum += ItemChanger.ReturnIsinWithOutIn(item);
            }
        } 

        [Benchmark]
        public void ChangeWithInClass()
        {
            int sum = 0;
            foreach (Item item in items)
            {
                sum += ItemChanger.ReturnIsinWithIn(item);
            }
        }

        [Benchmark]
        public void ChangeWithoutInStruct()
        {
            int sum = 0;
            foreach (ItemStruct item in itemsStruct)
            {
                sum += ItemChanger.ReturnIsinWithoutInStruct(item);
            }
        }

        [Benchmark]
        public void ChangeWithInStruct()
        {
            int sum = 0;
            foreach (ItemStruct item in itemsStruct)
            {
                sum += ItemChanger.ReturnIsinWithInStruct(item);
            }
        }

        [Benchmark]
        public void ChangeWithoutInRecord()
        {
            int sum = 0;
            foreach (ItemRecord item in itemsRecord)
            {
                sum += ItemChanger.ReturnIsinWithoutInRecord(item);
            }
        }

        [Benchmark]
        public void ChangeWithInRecord()
        {
            int sum = 0;
            foreach (ItemRecord item in itemsRecord)
            {
                sum += ItemChanger.ReturnIsinWithInRecord(item);
            }
        }
    }
}
