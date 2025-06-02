using AppEventosPet.Models;

namespace AppEventosPet.Views;

public partial class ResumoEvento : ContentPage
{
    public ResumoEvento(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento;
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
