using System;
using System.Linq;

namespace Interview
{
    public class ReciptService
    {
        public IOrderRepository orderRepository;

        public ReciptService()
        {
            orderRepository = new DummyOrderRepository();
        }

        public string CreateReciptHtml(Guid orderId)
        {
            var order = orderRepository.Find(orderId);

            return CreateHtml(order);
        }

        private string CreateHtml(Order order)
        {
            string a = "<div class=\"recipt\">";
            a += "<span>Data:" + DateTime.Now + "</span>";
            a += "<span>Pracownik:" + UserContext.User.Name + "</span>";

            var Gen = new ReciptItemGenerator();
            foreach (var item in order.Items)
            {
                a += "<li>" + Gen.FormatName(item.Name) + Gen.FormatPrice(item.Price) + "</li>";
            }

            a += "<strong>Suma: " + order.Items.Select(n => n.Price).Sum() + "</strong>";

            return a;
        }
    }
}
