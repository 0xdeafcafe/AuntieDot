using System.Linq;

// ReSharper disable CheckNamespace
namespace Microsoft.Phone.Shell
// ReSharper restore CheckNamespace
{
    public static class ApplicationBarHelpers
    {
        public static void Enable(this IApplicationBar appBar)
        {
            appBar.IsMenuEnabled = true;

            foreach (var button in appBar.Buttons.OfType<ApplicationBarIconButton>())
            {
                button.IsEnabled = true;
            }
        }

        public static void Disable(this IApplicationBar appBar)
        {
            appBar.IsMenuEnabled = false;

            foreach (var button in appBar.Buttons.OfType<ApplicationBarIconButton>())
            {
                button.IsEnabled = false;
            }
        }
    }
}