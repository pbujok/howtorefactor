using System;

namespace Interview
{
    public class DummyOrderRepository : IOrderRepository
    {
        public Order Find(Guid id)
        {
            return new Order
            {
                Id = Guid.NewGuid()
            };
        }
    }
}
