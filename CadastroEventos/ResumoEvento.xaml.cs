
namespace CadastroEventos
{
    public partial class ResumoEvento : ContentPage, IQueryAttributable
    {
        public ResumoEvento()
        {
            InitializeComponent();
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.TryGetValue("Evento", out var evento))
            {
                BindingContext = evento;
            }
        }
    }
}
