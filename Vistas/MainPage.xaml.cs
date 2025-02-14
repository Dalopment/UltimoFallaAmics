using App_Amics.Modelos;
using Firebase.Database;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;

namespace App_Amics.Vistas;

public partial class MainPage : ContentPage
{
    // Declaramos un objeto FirebaseClient que nos permite conectarnos a nuestra base de datos
    private readonly FirebaseClient _firebaseClient;

    public MainPage()
    {
        InitializeComponent();
        // Inicializamos Firebase usando la URL de nuestra base de datos
        _firebaseClient = new FirebaseClient("https://amicsnaquera-default-rtdb.firebaseio.com/");
    }

    private async void AceptarDni_Clicked(object sender, EventArgs e)
    {
        // Evento cuando el usuario hace clic en el botón "Aceptar"
        string dniIngresado = DniEntry.Text?.Trim();

        // Verificar si el usuario ingresó un DNI
        if (string.IsNullOrWhiteSpace(dniIngresado))
        {
            await DisplayAlert("Error", "Valor introducido no válido", "Aceptar");
            DniEntry.Text = string.Empty;
            DniEntry.Focus();
        }

        // Verificar en Firebase si el DNI existe
        bool dniExiste = await VerificarDniEnFirebase(dniIngresado);

        // Actuar según el resultado de la búsqueda
        if (dniExiste)
        {
            await DisplayAlert("Éxito", "Bienvenido a la Falla Amics de Naquera", "Aceptar");
            await Shell.Current.GoToAsync("//Login");
        }
        else
        {
            await DisplayAlert("Error", "El DNI introducido no pertenece a ningún fallero de la Falla Amics \nSi quieres pertener a la Falla Amics puedes escribirnos a través de nuestra cuenta de Facebook", "Aceptar");
        }
    }

    // Función para buscar el DNI en Firebase
    private async Task<bool> VerificarDniEnFirebase(string dni)
    {
        var usuarios = await _firebaseClient
            .Child("usuario") // Accede al nodo donde están los usuarios
            .OnceAsync<Usuario>(); // Obtiene los subnodos como objetos de tipo Usuario

        return usuarios.Any(u => u.Object.dni != null && u.Object.dni.ToLower() == dni.ToLower());
    }


}

