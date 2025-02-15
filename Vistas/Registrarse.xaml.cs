namespace App_Amics.Vistas;

public partial class Registrarse : ContentPage
{
	public Registrarse()
	{
		InitializeComponent();
	}

    private void Aceptar_Registro_Clicked(object sender, EventArgs e)
    {

    }

    private bool isPasswordVisible = false;
    private void verContraseñaButton_Clicked(object sender, EventArgs e)
    {
        // Cambiar la visibilidad de la contraseña
        isPasswordVisible = !isPasswordVisible;

        // Cambiar la propiedad IsPassword
        registroContraseñaEntry.IsPassword = !isPasswordVisible;

        //Cambiar el icono del boton (ojo abierto/cerrado)
        verContraseñaButton.Source = isPasswordVisible ? "ojo.png" : "hide.png";


    }

    private void verContraseña2Button_Clicked(object sender, EventArgs e)
    {
        //Cambiar la visibilidad de la contraseña
        isPasswordVisible = !isPasswordVisible;

        //Cambiar la propiedad IsPassword
        registroContraseña2Entry.IsPassword = !isPasswordVisible;

        //Cambiar el icono del boton (ojo abierto/cerrad)
        verContraseña2Button.Source = isPasswordVisible ? "ojo.png" : "hide.png";
    }
}