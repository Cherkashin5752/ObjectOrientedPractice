using Newtonsoft.Json;

namespace ObjectOrientedPractics.Service
{
    /// <summary>
    /// Сервисный класс для сериализации и десереализации магазина.
    /// </summary>
    internal static class ProjectSerializer
    {
        /// <summary>
        /// Настройки для сериализации.
        /// </summary>
        private static readonly JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        };

        /// <summary>
        /// Выполняет десериализацию списка товаров из файла формат JSON.
        /// </summary>
        /// <param name="relativePath">Путь к файлу, содержащему данные о списке товаров.</param>
        /// <returns>Список</returns>
        public static T? Deserialize<T>(string relativePath)
        {
            string fullPath = Path.Combine(PathService.GetProjectRootDir(), relativePath);

            return File.Exists(fullPath)
                ? JsonConvert.DeserializeObject<T>(File.ReadAllText(fullPath), _settings)
                : default;
        }

        /// <summary>
        /// Сериализует список
        /// </summary>
        /// <param name="data">Список, который необходимо сериализовать</param>
        /// <param name="relativePath">Путь к файлу, в который будут записаны данные</param>
        public static void Serialize<T>(T data, string relativePath)
        {
            string fullPath = Path.Combine(PathService.GetProjectRootDir(), relativePath);

            PathService.CreateDirectoryExist(relativePath);

            File.WriteAllText(fullPath, JsonConvert.SerializeObject(data, Formatting.Indented, _settings));
        }
    }
}
