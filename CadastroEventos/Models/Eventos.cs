namespace CadastroEventos.Models
{
    public class Evento
    {
        public string NomeEvento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public double CustoPorParticipante { get; set; }
    }
}