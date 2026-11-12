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
    public int DuracaoEmDias
        {
            get
            {
                TimeSpan duracao = DataTermino - DataInicio;
                return duracao.Days;
            }
        }

        public double CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante;
            }
        }
    }