
namespace CadastroEventos
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ResumoEvento), typeof(ResumoEvento));
        }
    }
}
