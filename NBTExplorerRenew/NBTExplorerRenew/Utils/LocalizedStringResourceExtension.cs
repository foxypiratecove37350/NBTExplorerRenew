using Microsoft.UI.Xaml.Markup;
using Windows.ApplicationModel.Resources;

namespace NBTExplorerRenew.Utils
{
    [MarkupExtensionReturnType(ReturnType = typeof(string))]
    public sealed partial class LocalizedStringResourceExtension : MarkupExtension
    {
        private static readonly ResourceLoader resourceLoader = ResourceLoader.GetForViewIndependentUse();

        public string? Name
        {
            get; set;
        }

        protected override object ProvideValue()
        {
            return resourceLoader.GetString(Name);
        }
    }
}
