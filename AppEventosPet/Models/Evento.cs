namespace AppEventosPet.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Tipo { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime DataTermino { get; set; } = DateTime.Now;
        public int NumeroParticipantes { get; set; } = 1;
        public double CustoPorParticipante { get; set; }
    }
}
