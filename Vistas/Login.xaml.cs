namespace App_Amics.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void Aceptar_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }

    private async void Registrarse_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Registrarse");
    }
}