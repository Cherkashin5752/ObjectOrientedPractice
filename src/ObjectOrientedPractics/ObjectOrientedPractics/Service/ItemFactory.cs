using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Service
{
    /// <summary>
    /// Сервисный класс для создания товаров со случайными состояниями
    /// </summary>
    static internal class ItemFactory
    {
        /// <summary>
        /// Количество товаров, лежащее в прочтённых файлах
        /// </summary>
        static private int maxItemsCount;
        
        /// <summary>
        /// Список наименований товаров, прочтённых из файла
        /// </summary>
        static private List<string> _names = new List<string>();

        /// <summary>
        /// Список описаний для товаров, прочтённых из файла
        /// </summary>
        static private List<string> _info = new List<string>();

        static private Random _random = new Random();
        /// <summary>
        /// Генерирует и возвращает товар со случайным состоянием
        /// </summary>
        /// <returns></returns>
        static public Item GenerateItem()
        {
            int randomItem = _random.Next(maxItemsCount);

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

            ProductCategory newCategory = (ProductCategory)_random.Next(Enum.GetNames<ProductCategory>().Length);

            Item newItem = new Item(newName, newInfo, newCost, newCategory);

            return newItem;
        }

        /// <summary>
        /// Настраивает класс ItemsFactory, считывает файлы с заранее записанными данными
        /// </summary>
        static public void SetUpItemFactory()
        {
            string reader = File.ReadAllText(PathService.GetProjectRootDir() + "\\Preload Data\\Items Names.json");

            if (reader != null)
            {
                _names = JsonConvert.DeserializeObject<List<string>>(reader);
            }

            reader = File.ReadAllText(PathService.GetProjectRootDir() + "\\Preload Data\\Items Info.json");

            if (reader != null)
            {
                _info = JsonConvert.DeserializeObject<List<string>>(reader);
            }

            if (_names != null && _info != null)
            {
                maxItemsCount = int.Min(_names.Count, _info.Count);
            }
        }
    }
}
