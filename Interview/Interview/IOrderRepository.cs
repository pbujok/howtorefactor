using System;
using System.Collections;

namespace Interview
{
    public interface IOrderRepository
    {
        public Order Find(Guid id);
    }
}
