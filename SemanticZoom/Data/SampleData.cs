using System.Collections.Generic;

namespace SemanticZoom.Data
{
    internal class SampleDataGroup
    {
        public string Name { get; set; }

        public List<SampleData> Items { get; set; }
    }

    internal class SampleData
    {
        public SampleData(string title)
        {
            Title = title;
        }

        public string Title { get; private set; }
    }
}
