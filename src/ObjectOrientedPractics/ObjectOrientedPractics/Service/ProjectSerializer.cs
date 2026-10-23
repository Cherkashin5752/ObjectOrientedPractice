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
        /// <param name="relativePath">Путь к файлу, содержащему данные о списке товаров.</param>
        /// <returns>Список</returns>
        static public T? Deserialize<T>(string relativePath)
        {
            string fullPath = Path.Combine(PathService.GetProjectRootDir(), relativePath);

            return File.Exists(fullPath)
                ? JsonConvert.DeserializeObject<T>(File.ReadAllText(fullPath))
                : default;
        }

        /// <summary>
        /// Сериализует список
        /// </summary>
        /// <param name="data">Список, который необходимо сериализовать</param>
        /// <param name="path">Путь к файлу, в который будут записаны данные</param>
        static public void Serialize<T>(T data, string relativePath)
        {
            string fullPath = Path.Combine(PathService.GetProjectRootDir(), relativePath); ;

            PathService.CreateDirectoryExist(relativePath);

            File.WriteAllText(fullPath, JsonConvert.SerializeObject(data, Formatting.Indented));
        }
    }
}
