namespace Registro;

public partial class AlarmPage : ContentPage
{
	public AlarmPage()
	{
		InitializeComponent();
	}

    private async void ShowPopup(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddAlarmPage()); // Abre la ventana emergente
    }
}