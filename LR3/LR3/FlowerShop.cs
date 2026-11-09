using System;

namespace LR3
{
    /// <summary>
    /// Цветочный магазин: ассортимент, корзина покупателя и обработка заказа.
    /// </summary>
    public class FlowerShop
    {
        private readonly Product[] assortment_;
        private readonly int[] requested_;

        public FlowerShop()
        {
            assortment_ = new Product[]
            {
                new Product("роза", 180, 24),
                new Product("тюльпан", 120, 30),
                new Product("хризантема", 350, 14),
                new Product("орхидея", 1200, 6),
                new Product("гипсофила", 90, 40)
            };

            requested_ = new int[assortment_.Length];
        }
    }
}
