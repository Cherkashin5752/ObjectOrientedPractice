using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ObjectOrientedPractics.Service
{
    static internal class PathService
    {
        static public string GetProjectRootDir()
        {
            string tempPath = Assembly.GetExecutingAssembly().Location;

            string path = "";

            for (int i = 0; i < tempPath.LastIndexOf("\\"); i++)
            {
                path += tempPath[i];
            }

            return path;
        }
    }
}
