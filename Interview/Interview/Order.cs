using System;
using System.Collections;
using System.Collections.Generic;

namespace Interview
{
    public class Order
    {
        public Guid Id { get; set; }

        public ICollection<Item> Items { get; set; }
    }

    public class Item
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public Guid OrderId { get; set; }
    }

    public class User
    {
        public string Name { get; set; }
    }
}
