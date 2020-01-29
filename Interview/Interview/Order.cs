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
}
