using Microsoft.Maui.Controls;

namespace ejercicio1
{
    public partial class ResultPage : ContentPage
    {
        public ResultPage(double resultado)
        {
            InitializeComponent();

            // Encuentra el elemento Label llamado "ResultadoLabel"
            var ResultadoLabel = this.FindByName<Label>("ResultadoLabel");

            if (ResultadoLabel != null)
            {
                ResultadoLabel.Text = $"Resultado: {resultado}";
            }
        }
    }
}
