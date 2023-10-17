using Microsoft.Maui.Controls;

namespace ejercicio1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CalcularButton_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(Numero1Entry.Text, out double num1) && double.TryParse(Numero2Entry.Text, out double num2))
            {
                double resultado = 0;
                string operacion = OperacionPicker.SelectedItem.ToString();

                switch (operacion)
                {
                    case "Suma":
                        resultado = num1 + num2;
                        break;
                    case "Resta":
                        resultado = num1 - num2;
                        break;
                    case "Multiplicación":
                        resultado = num1 * num2;
                        break;
                    case "División":
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            DisplayAlert("Error", "No se puede dividir por cero.", "Aceptar");
                            return;
                        }
                        break;
                }

                // Pasa el resultado a la segunda página a través del constructor
                Navigation.PushAsync(new ResultPage(resultado));
            }
            else
            {
                DisplayAlert("Error", "Ingresa números válidos.", "Aceptar");
            }
        }
    }
}
