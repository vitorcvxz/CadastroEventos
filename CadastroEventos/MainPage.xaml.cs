
using CadastroEventos.Models;

namespace CadastroEventos;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = new Evento
        {
            DataInicio = DateTime.Today,
            DataTermino = DateTime.Today.AddDays(1)
        };
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        Evento evento = (Evento)BindingContext;

        await Shell.Current.GoToAsync(nameof(ResumoEvento), true, new Dictionary<string, object>
        {
            { "Evento", evento }
        });
    }
}
