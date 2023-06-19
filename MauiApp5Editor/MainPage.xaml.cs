namespace MauiApp5Editor;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private void Editor_TextChanged(object sender, TextChangedEventArgs e)
    {
		string pasado = e.OldTextValue;
		string futuro= e.NewTextValue;
    }

    private void Editor_Completed(object sender, EventArgs e)
    {
		string textoFinal=((Editor)sender).Text;
    }
}

