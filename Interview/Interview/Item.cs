using System;

namespace Interview
{
    public class Item
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public Guid OrderId { get; set; }
    }
}
