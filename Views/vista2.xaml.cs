namespace jcevallosT3A.Views;

public partial class vista2 : ContentPage
{
	public vista2(string usuario)
	{
		InitializeComponent();
        lblUusario.Text = "usuario conectado " + usuario;
    }
    private void btnAbrir_Clicked(object sender, EventArgs e)
    {

    }
}