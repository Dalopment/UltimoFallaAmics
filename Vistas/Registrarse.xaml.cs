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
    private void verContrase�aButton_Clicked(object sender, EventArgs e)
    {
        // Cambiar la visibilidad de la contrase�a
        isPasswordVisible = !isPasswordVisible;

        // Cambiar la propiedad IsPassword
        registroContrase�aEntry.IsPassword = !isPasswordVisible;

        //Cambiar el icono del boton (ojo abierto/cerrado)
        verContrase�aButton.Source = isPasswordVisible ? "ojo.png" : "hide.png";


    }

    private void verContrase�a2Button_Clicked(object sender, EventArgs e)
    {
        //Cambiar la visibilidad de la contrase�a
        isPasswordVisible = !isPasswordVisible;

        //Cambiar la propiedad IsPassword
        registroContrase�a2Entry.IsPassword = !isPasswordVisible;

        //Cambiar el icono del boton (ojo abierto/cerrad)
        verContrase�a2Button.Source = isPasswordVisible ? "ojo.png" : "hide.png";
    }
}