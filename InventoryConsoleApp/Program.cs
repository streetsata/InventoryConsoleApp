/*
 * Створіть програму, яка дозволяє додавати, видаляти та змінювати товари в інвентарі магазину.
 * Включіть функціонал для пошуку товарів за різними критеріями (назва, категорія, ціна тощо).
 * Забезпечте можливість зберігання та завантаження даних про товари з файлу.
 */

using System.Data;

namespace InventoryConsoleApp
{
    public class Program
    {
        static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {
            // TODO
            // UI
            ShowUI();
        }

        private static void ShowUI()
        {
            while (true)
            {
                Console.WriteLine("1. Додати товар");
                Console.WriteLine("2. Видалити товар");
                Console.WriteLine("3. Змінити інформацію про товар");
                Console.WriteLine("4. Пошук товару");
                Console.WriteLine("5. Показати всі товари"); // Має вичитувати з файлу
                Console.WriteLine("6. Зберегти в файл");
                Console.WriteLine("7. Вихід");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        RemoveProduct();
                        break;
                    case 3:
                        UpdateProduct();
                        break;
                    case 4:
                        SearchProduct();
                        break;
                    case 5:
                        ShowAllProducts();
                        break;
                    case 6:
                        SaveProductToFile("products.txt");
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Некоректний вибір. Спробуйте ще");
                        Console.Clear();
                        break;
                }
            }
        }

        private static void AddProduct()
        {
            // TODO
            // Реалізація додавання товару
        }
        private static void RemoveProduct()
        {
            // TODO
            // Реалізація видалення товару
        }
        private static void UpdateProduct()
        {
            // TODO
            // Реалізація update товару
        }
        private static void SearchProduct()
        {
            // TODO
            // Реалізація пошуку товарів за різними критеріями (назва, категорія, ціна тощо)
        }
        private static void ShowAllProducts()
        {
            // TODO
            // Реалізація показу всіх товарі, завантаження з файлу
        }
        private static void SaveProductToFile(string v)
        {
            // TODO
            // Збереження продуктів у файл
        }
    }
}
