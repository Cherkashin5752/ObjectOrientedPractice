using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ObjectOrientedPractics.Service
{
    static internal class PathService
    {
        /// <summary>
        /// Возвращает относительный путь к дериктории исполняемого файла программы
        /// </summary>
        /// <returns>Путь к исполняемому файлу проекта</returns>
        static public string GetProjectRootDir()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        static public void CreateDirectoryExist(string path)
        {
            string directory = Path.GetDirectoryName(Path.Combine(PathService.GetProjectRootDir(), path));

            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
    }
}
