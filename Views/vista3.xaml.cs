namespace jcevallosT3A.Views;

public partial class vista3 : ContentPage
{
	public vista3()
	{
		InitializeComponent();
	}
    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        String usuario = txtUusuario.Text;
        String contrasena = txtContraseña.Text;
        DisplayAlert("Alert", "Usuario almacenada", "Ok");
        Navigation.PushAsync(new vista1());

    }
}