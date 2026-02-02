using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Extensions;

namespace MauiBugsPopup
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenPopup(object? sender, EventArgs e)
        {
            var popup = new SamplePopup();
            this.ShowPopup(popup, new PopupOptions
            {
                CanBeDismissedByTappingOutsideOfPopup = true,
            });
        }
    }
}
