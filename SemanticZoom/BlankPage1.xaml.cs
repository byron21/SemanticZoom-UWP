using System.Diagnostics;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace SemanticZoom
{
    // This sample is based in https://code.msdn.microsoft.com/How-to-use-Semantic-Zoom-6523bc12
    // Thanks to Suresh-M
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
            Debug.WriteLine("Started SemanticZoomDemo");

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var collectionGroups = Collection.View.CollectionGroups;
            ((ListViewBase)this.semanticZoom.ZoomedOutView).ItemsSource = collectionGroups;
        }
    }
}
