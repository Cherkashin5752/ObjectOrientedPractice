using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Service
{
    /// <summary>
    /// Сервисный класс для создания товаров со случайными состояниями.
    /// </summary>
    internal static class ItemFactory
    {
        /// <summary>
        /// Количество товаров, лежащее в прочтённых файлах.
        /// </summary>
        private static int _maxItemsCount;
        
        /// <summary>
        /// Список наименований товаров, прочтённых из файла.
        /// </summary>
        private static List<string> _names = new List<string>();

        /// <summary>
        /// Список описаний для товаров, прочтённых из файла.
        /// </summary>
        private static List<string> _info = new List<string>();
        
        /// <summary>
        /// Список категорий продуктов, прочтённых из файлов.
        /// </summary>
        private static List<ProductCategory> _categories = new List<ProductCategory>();

        /// <summary>
        /// Генератор случайных чисел.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Генерирует и возвращает товар со случайным состоянием.
        /// </summary>
        /// <returns>Возвращает новый экземпляр класса <see cref="Item"/>.</returns>
        public static Item GenerateItem()
        {
            int randomItem = _random.Next(_maxItemsCount);

            string newName, newInfo;

            if (_names != null)
            {
                newName = _names[randomItem];
            }
            else
            {
                newName = "Default";
            }

            if (_info != null)
            {
                newInfo = _info[randomItem];
            }
            else
            {
                newInfo = "Default";
            }

            int newCost = _random.Next(100_000);

            ProductCategory newCategory = _categories[_random.Next(_categories.Count)];

            Item newItem = new Item(newName, newInfo, newCost, newCategory);

            return newItem;
        }

        /// <summary>
        /// Настраивает класс ItemsFactory, считывает файлы с заранее записанными данными/
        /// </summary>
        public static void SetUpItemFactory()
        {
            _names = ProjectSerializer.Deserialize<List<string>>("Preload Data\\Items Names.json");
            _info = ProjectSerializer.Deserialize<List<string>>("Preload Data\\Items Info.json");

            _categories = Enum.GetValues<ProductCategory>().ToList();

            if (_names != null && _info != null)
            {
                _maxItemsCount = int.Min(_names.Count, _info.Count);
            }
        }
    }
}
