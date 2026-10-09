using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedPractics.Model;
using System.ComponentModel;

namespace ObjectOrientedPractics.Service
{
    static internal class ProjectSerializer
    {
        /// <summary>
        /// Выполняет десериализацию списка товаров из файла формат JSON.
        /// </summary>
        /// <param name="path">Путь к файлу, содержащему данные о списке товаров.</param>
        /// <returns>Список товаров в виде <see cref="BindingList{T}"/></returns>
        static public BindingList<Item> DeserializeJsonItemsFile(string path)
        {
            string itemsJsonText = File.ReadAllText(PathService.GetProjectRootDir() + path);

            BindingList<Item> items = JsonConvert.DeserializeObject<BindingList<Item>>(itemsJsonText);

            return items;
        }

        /// <summary>
        /// Сериализует список товаров в формат JSON и сохраняет его в указанный файл.
        /// </summary>
        /// <param name="BindingList{T}">Список товаров <see cref="BindingList{T}"/> для сохранения.</param>
        /// <param name="path">Путь к файлу, в который будут записаны данные.</param>
        static public void SerializeJsonItemsFile(BindingList<Item> items, string path)
        {
            string jsonStore = JsonConvert.SerializeObject(items);

            File.WriteAllText(PathService.GetProjectRootDir() + path, jsonStore);
        }

        /// <summary>
        /// Выполняет десериализацию списка товаров из файла формат JSON.
        /// </summary>
        /// <param name="path">Путь к файлу, содержащему данные о списке товаров.</param>
        /// <returns>Список товаров в виде <see cref="BindingList{T}"/></returns>
        static public BindingList<Customer> DeserializeJsonCustomersFile(string path)
        {
            string customersJsonText = File.ReadAllText(PathService.GetProjectRootDir() + path);

            BindingList<Customer> customers = JsonConvert.DeserializeObject<BindingList<Customer>>(customersJsonText);

            return customers;
        }

        /// <summary>
        /// Сериализует список товаров в формат JSON и сохраняет его в указанный файл.
        /// </summary>
        /// <param name="BindingList{T}">Список товаров <see cref="BindingList{T}"/> для сохранения.</param>
        /// <param name="path">Путь к файлу, в который будут записаны данные.</param>
        static public void SerializeJsonCustomersFile(BindingList<Customer> customers, string path)
        {
            string jsonCustomers = JsonConvert.SerializeObject(customers);

            File.WriteAllText(PathService.GetProjectRootDir() + path, jsonCustomers);
        }
    }
}
