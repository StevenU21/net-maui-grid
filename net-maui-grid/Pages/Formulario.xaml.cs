namespace net_maui_grid.Pages;

public partial class Formulario : ContentPage
{
	public Formulario()
	{
		InitializeComponent();
	}

    private void OnEnviarClicked(object sender, EventArgs e)
    {
        string nombre = NombreEntry.Text;
        string correo = CorreoEntry.Text;
        string mensaje = MensajeEditor.Text;

        if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(mensaje))
        {
            ResultadoLabel.Text = "Por favor, complete todos los campos.";
            ResultadoLabel.TextColor = Colors.Red;
        }
        else
        {
            ResultadoLabel.Text = $"¡Formulario enviado con éxito!\n\n" +
                                  $"Nombre: {nombre}\n" +
                                  $"Correo: {correo}\n" +
                                  $"Mensaje: {mensaje}";
            ResultadoLabel.TextColor = Colors.Green;
        }
    }
}