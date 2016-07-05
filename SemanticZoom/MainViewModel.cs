using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.StoreApps;
using SemanticZoom.Data;

namespace SemanticZoom
{
    internal class MainViewModel : BindableBase
    {
        public MainViewModel()
        {
            Groups = new ObservableCollection<SampleDataGroup>(SampleDataGenerator.GetGroupedData());
        }

        private ObservableCollection<SampleDataGroup> _groups;
        public ObservableCollection<SampleDataGroup> Groups
        {
            get { return _groups; }
            set { SetProperty(ref _groups, value); }
        }
    }
}
