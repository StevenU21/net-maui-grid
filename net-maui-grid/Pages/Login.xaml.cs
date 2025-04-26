namespace net_maui_grid.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
    private void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        ResultLabel.Text = $"Usuario: {username}\nContraseña: {password}";
    }
}