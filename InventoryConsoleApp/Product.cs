/*
 * Створіть програму, яка дозволяє додавати, видаляти та змінювати товари в інвентарі магазину.
 * Включіть функціонал для пошуку товарів за різними критеріями (назва, категорія, ціна тощо).
 * Забезпечте можливість зберігання та завантаження даних про товари з файлу.
 */

namespace InventoryConsoleApp
{
    // Data model
    public class Product
    {
        // Properties
        public Guid Id { get; set; } // Unique identify
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
