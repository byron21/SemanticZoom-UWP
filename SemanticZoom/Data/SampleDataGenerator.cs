using System.Collections.Generic;
using System.Linq;

namespace SemanticZoom.Data
{
    internal class SampleDataGenerator
    {
        private static List<SampleData> _data;

        public static List<SampleDataGroup> GetGroupedData()
        {
            if(_data == null)
                GenerateData();

            return _data.GroupBy(d => d.Title.Split(' ')[0],
                (key, items) => new SampleDataGroup {Name = key, Items = items.ToList()}).ToList();
        }

        private static void GenerateData()
        {
            string[] strArray = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" };

            _data = new List<SampleData>();
            foreach (string letter in strArray)
            {
                for (int i = 1; i < 6; i++)
                {
                    _data.Add(new SampleData(letter + " item" + i));
                }
            }

        }
    }
}
