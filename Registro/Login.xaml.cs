namespace Registro;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

	private async void RecuperarContra (object sender, EventArgs e)
	{
		await Navigation.PushAsync(new correo());
	}

    private async void horario(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AlarmPage());
    }
}