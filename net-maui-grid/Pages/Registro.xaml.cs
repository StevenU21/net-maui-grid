using System.Collections.Generic;

namespace net_maui_grid.Pages;

public partial class Registro : ContentPage
{
    private readonly List<string> productosIngresados = new();

    public Registro()
    {
        InitializeComponent();
    }

    private void OnIngresarProductoClicked(object sender, EventArgs e)
    {
        string nombreProducto = NombreProductoEntry.Text;
        string cantidad = CantidadMateriaPrimaEntry.Text;
        string condiciones = CondicionesTemperaturaEntry.Text;

        if (string.IsNullOrWhiteSpace(nombreProducto) || string.IsNullOrWhiteSpace(cantidad) || string.IsNullOrWhiteSpace(condiciones))
        {
            ResultadoLabel.Text = "Por favor, complete todos los campos.";
            ResultadoLabel.TextColor = Colors.Red;
        }
        else
        {
            string producto = $"Nombre: {nombreProducto}, Cantidad: {cantidad}, Condiciones: {condiciones}";
            productosIngresados.Add(producto);

            ResultadoLabel.Text = "Producto ingresado correctamente.";
            ResultadoLabel.TextColor = Colors.Green;

            NombreProductoEntry.Text = string.Empty;
            CantidadMateriaPrimaEntry.Text = string.Empty;
            CondicionesTemperaturaEntry.Text = string.Empty;
        }
    }

    private void OnVerStockClicked(object sender, EventArgs e)
    {
        if (productosIngresados.Count == 0)
        {
            ResultadoLabel.Text = "No hay productos en el stock.";
            ResultadoLabel.TextColor = Colors.Orange;
        }
        else
        {
            ResultadoLabel.Text = "Productos en el stock:\n" + string.Join("\n", productosIngresados);
            ResultadoLabel.TextColor = Colors.Blue;
        }
    }
}
