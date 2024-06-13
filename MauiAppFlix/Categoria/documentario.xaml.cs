namespace MauiAppFlix.Categoria;

public partial class documentario : ContentPage
{
	public documentario()
	{
		InitializeComponent();
	}


    private void sennabtn_Clicked(object
    sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new documentario.do_senna());
        }
        catch (EXpextion ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}

private void marieelebtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new documentario.do_marieele());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void pelebtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new documentario.do_pele());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void elenabtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new aventura.documentario.do_elena());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}