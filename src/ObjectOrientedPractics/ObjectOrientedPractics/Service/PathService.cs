namespace ObjectOrientedPractics.Service
{
    /// <summary>
    /// Сервисный класс для работы с путями в проекте.
    /// </summary>
    internal static class PathService
    {
        /// <summary>
        /// Возвращает относительный путь к директории исполняемого файла программы
        /// </summary>
        /// <returns>Путь к исполняемому файлу проекта</returns>
        public static string GetProjectRootDir()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        /// <summary>
        /// Проверяет, существует ли директория, в которой ищется файл по пути <paramref name="{path}">. Если нет - создаёт её
        /// </summary>
        /// <param name="path">Путь, в котором ищёт файлю</param>
        public static void CreateDirectoryExist(string path)
        {
            string directory = Path.GetDirectoryName(Path.Combine(PathService.GetProjectRootDir(), path));

            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
    }
}
