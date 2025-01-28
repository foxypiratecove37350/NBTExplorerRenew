using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Input;

namespace NBTExplorerRenew.Resources
{
    public sealed partial class Commands : ResourceDictionary
    {
        public Commands()
        {
            InitializeComponent();
        }

        public void OpenCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void OpenFolderCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void OpenSoftwareHomeFolderCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void OpenInFileExplorerCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void SaveCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void RefreshCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void ExitCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {
            Application.Current.Exit();
        }

        public void CutCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void CopyCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void PasteCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void RenameCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void EditValueCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void DeleteCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void MoveUpCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void MoveDownCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void FindCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void FindNextCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void ReplaceCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void ChunkFinderCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }

        public void AboutCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {
            new AboutWindow().Activate();
        }

        public void SettingsCommand_ExecuteRequested(XamlUICommand sender, ExecuteRequestedEventArgs e)
        {

        }
    }
}
