namespace Registro;

public partial class AddAlarmPage : ContentPage
{
	public AddAlarmPage()
	{
		InitializeComponent();
	}

    private async void ClosePopup(object sender, EventArgs e)
	{
		await Navigation.PopModalAsync(); // Cierra la ventana emergente
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}