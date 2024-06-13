namespace MauiAppFlix.Categoria;

public partial class nacional : ContentPage
{
	public nacional()
	{
		InitializeComponent();
	}


    private void cidadededeusbtn_Clicked(object
    sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new nacional.nacional_cidadededeus());
        }
        catch (EXpextion ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}

private void osfarofeirosbtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new nacional.nacional_osfarofeiros());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void bacuraubtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new nacional.nacional_bacurau());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void minhamaebtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new nacional.nacional_minhame());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}