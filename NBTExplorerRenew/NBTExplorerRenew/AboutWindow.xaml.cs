using Microsoft.UI.Xaml;
using Windows.ApplicationModel;
using Windows.ApplicationModel.DataTransfer;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NBTExplorerRenew
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AboutWindow : Window
    {
        public string Version
        {
            get
            {
                PackageVersion version = Package.Current.Id.Version;
                return string.Format("{0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision);
            }
        }

        public AboutWindow()
        {
            ExtendsContentIntoTitleBar = true;
            InitializeComponent();
            SetTitleBar(TitleBar);
        }

        private void CloneRepo_Click(object sender, RoutedEventArgs e)
        {
            DataPackage dp = new();
            dp.SetText(GitCloneTextBlock.Text);
            Clipboard.SetContent(dp);
        }
    }
}
