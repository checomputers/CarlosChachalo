using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarlosChachalo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
         string usu = "carlos2022";
            string contra = "uisrael2022";

            string tusu = txtUsuario.Text;
            string tcontra = txtContrasena.Text;

            if (usu == tusu & contra == tcontra)
            {

                await DisplayAlert("BIENVENIDO", "USUARIO CORRECTO", "ACEPTAR");
                await Navigation.PushAsync(new Registro(txtUsuario.Text));
            }

            else
            {
                await DisplayAlert("ERROR", "USUARIO O CONTRASEÑA INCORRECTA", "CERRAR");
            }
        }
    }
}