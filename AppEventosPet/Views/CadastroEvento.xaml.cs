using AppEventosPet.Models;
using System.Collections.ObjectModel;

namespace AppEventosPet.Views;

public partial class CadastroEvento : ContentPage
{
    public ObservableCollection<string> TiposEvento { get; set; }
    public ObservableCollection<string> Cidades { get; set; }
    public Evento Evento { get; set; }

    public CadastroEvento()
    {
        InitializeComponent();

        TiposEvento = new ObservableCollection<string>
        {
            "Feira Pet", "Adoção", "Passeio", "Palestra", "Vacinação"
        };

        Cidades = new ObservableCollection<string>
        {
            "São Paulo", "Rio de Janeiro", "Curitiba", "Belo Horizonte", "Porto Alegre"
        };

        Evento = new Evento
        {
            CustoPorParticipante = 100 // Definindo custo fixo
        };

        BindingContext = this;
    }

    private async void OnCadastrarClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Evento.Nome) ||
            string.IsNullOrWhiteSpace(Evento.Cidade) ||
            string.IsNullOrWhiteSpace(Evento.Tipo) ||
            Evento.DataTermino < Evento.DataInicio)
        {
            await DisplayAlert("Erro", "Preencha todos os campos corretamente.", "OK");
            return;
        }

        await Navigation.PushAsync(new ResumoEvento(Evento));
    }
}
