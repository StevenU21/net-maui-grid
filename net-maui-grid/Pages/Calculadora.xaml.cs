namespace net_maui_grid.Pages;

public partial class Calculadora : ContentPage
{
	public Calculadora()
	{
		InitializeComponent();
	}

    private void OnOperationClicked(object sender, EventArgs e)
    {
        if (double.TryParse(FirstNumberEntry.Text, out double firstNumber) &&
            double.TryParse(SecondNumberEntry.Text, out double secondNumber))
        {
            var button = sender as Button;
            double result = 0;

            switch (button.Text)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "×":
                    result = firstNumber * secondNumber;
                    break;
                case "÷":
                    result = secondNumber != 0 ? firstNumber / secondNumber : double.NaN;
                    break;
            }

            ResultLabel.Text = $"Resultado: {result}";
        }
        else
        {
            ResultLabel.Text = "Por favor, ingrese números válidos.";
        }
    }
}