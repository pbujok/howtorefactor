namespace Interview
{
    public class ReciptItemGenerator
    {
        public string FormatName(string itemName)
        {
            return itemName.ToUpper();
        }

        public string FormatPrice(float price)
        {
            return price.ToString("C2");
        }
    }
}
