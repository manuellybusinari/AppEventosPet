namespace AppEventosPet.Models;

public class Evento
{
    public string Nome { get; set; }
    public string Cidade { get; set; }
    public string Tipo { get; set; }
    public DateTime DataInicio { get; set; } = DateTime.Today;
    public DateTime DataTermino { get; set; } = DateTime.Today;
    public int NumeroParticipantes { get; set; } = 1;
    public double CustoPorParticipante { get; set; }

    public int DuracaoEmDias => (DataTermino - DataInicio).Days + 1;

    public double CustoTotal => NumeroParticipantes * CustoPorParticipante;
}
