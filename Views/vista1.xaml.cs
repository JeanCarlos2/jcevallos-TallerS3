namespace jcevallosT3A.Views;

public partial class vista1 : ContentPage
{
	public vista1()
	{
		InitializeComponent();
	}
    string usuariof = "jean";
    string contrasenaf = "123";
    public vista1(string usuario, string contraseña)
    {
        this.usuariof = usuario;
        this.contrasenaf = contraseña;
        InitializeComponent();
    }
    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        if (txtUsuario.Text == usuariof && txContraseña.Text == contrasenaf)
        {
            Navigation.PushAsync(new Views.vista2(txtUsuario.Text));
        }
        else
        {
            DisplayAlert("Aelerta", "USUARIO INCORRECTO", "ok");
        }

    }
    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.vista3());
    }
}