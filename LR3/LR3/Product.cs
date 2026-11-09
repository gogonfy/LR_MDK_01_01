namespace LR3
{
    /// <summary>
    /// Товар цветочного магазина.
    /// </summary>
    public class Product
    {
        // Характеристики товара закрыты от изменения из других классов.
        private string name_;
        private int price_;
        private int quantity_;

        public Product(string name, int price, int quantity)
        {
            name_ = name;
            price_ = price;
            quantity_ = quantity;
        }
    }
}
