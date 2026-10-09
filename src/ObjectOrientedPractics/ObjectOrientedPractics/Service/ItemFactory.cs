using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Service
{
    static internal class ItemFactory
    {
        static private int maxItemsCount;

        static private List<string> _names = new List<string>();

        static private List<string> _info = new List<string>();

        static public Item GenerateItem()
        {
            Random random = new Random();

            int randomItem = random.Next(maxItemsCount);

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

            int newCost = random.Next(100_000);

            Item newItem = new Item(newName, newInfo, newCost);

            return newItem;
        }

        static public void SetUpItemFactory()
        {
            StreamReader reader = new StreamReader(PathService.GetProjectRootDir() + "\\Preload Data\\Items Names.json");

            if (reader != null)
            {
                _names = JsonConvert.DeserializeObject<List<string>>(reader.ReadToEnd());
            }

            reader.Close();

            reader = new StreamReader(PathService.GetProjectRootDir() + "\\Preload Data\\Items Info.json");

            if (reader != null)
            {
                _info = JsonConvert.DeserializeObject<List<string>>(reader.ReadToEnd());
            }

            reader.Close();

            if (_names != null && _info != null)
            {
                maxItemsCount = int.Min(_names.Count, _info.Count);
            }
        }
    }
}
