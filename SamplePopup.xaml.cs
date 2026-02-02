using CommunityToolkit.Maui.Views;

namespace MauiBugsPopup;

public partial class SamplePopup : Popup
{
	public SamplePopup()
	{
		InitializeComponent();

        // Necessary to wait, otherwise the software keyboard is not opened.
        Task.Run(async () =>
        {
            await Task.Delay(400);
            MainThread.BeginInvokeOnMainThread(() => SampleEntry.Focus());
        });
    }

	private async void ButtonClicked(object? sender, EventArgs e)
	{
		await SampleEntry.HideSoftInputAsync(CancellationToken.None);
		await CloseAsync();
    }
}