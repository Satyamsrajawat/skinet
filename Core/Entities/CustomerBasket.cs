namespace Core.Entities
{
    public class CustomerBasket
    {
        public string Id { get; set; }
        public List<BasktetItem> Items { get; set; }
    }
}