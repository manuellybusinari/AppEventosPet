using AppEventosPet.Models;

namespace AppEventosPet.Views;

public partial class ResumoEvento : ContentPage
{
    public Evento Evento { get; set; }

    public ResumoEvento(Evento evento)
    {
        InitializeComponent();
        Evento = evento;
        BindingContext = Evento;
    }
}
