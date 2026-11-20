using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Service
{
    public static class DataTools
    {
        public delegate bool ItemFilterFunc(Item item);

        public static List<Item> ItemsFilter(List<Item> items, ItemFilterFunc filterType)
        {
            List<Item> filteredList = new List<Item>();

            foreach (Item item in items)
            {
                if (filterType(item))
                {
                    filteredList.Add(item);
                }
            }

            return filteredList;
        }

        public static List<Item> ItemsSort(List<Item> items, Func<Item, Item, bool> sortType)
        {
            List<Item> sortedList = new List<Item>(items);

            for (int i = 0; i < sortedList.Count - 1; i++)
            {
                for (int j = i + 1; j < sortedList.Count; j++)
                {
                    if (sortType(sortedList[i], sortedList[j]))
                    {
                        Item temp = sortedList[i];
                        sortedList[i] = sortedList[j];
                        sortedList[j] = temp;
                    }
                }
            }

            return sortedList;
        }

        public static bool ByName(Item firstItem, Item secondItem)
        {
            return string.Compare(firstItem.Name, secondItem.Name, StringComparison.OrdinalIgnoreCase) > 0;
        }

        public static bool CostAscending(Item firstItem, Item secondItem)
        {
            return firstItem.Cost > secondItem.Cost;
        }

        public static bool CostDescending(Item firstItem, Item secondItem)
        {
            return firstItem.Cost < secondItem.Cost;
        }
    }
}
