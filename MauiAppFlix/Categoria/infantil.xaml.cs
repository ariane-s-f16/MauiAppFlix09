namespace MauiAppFlix.Categoria;

public partial class infantil : ContentPage
{
	public infantil()
	{
		InitializeComponent();
	}


    private void monstrossabtn_Clicked(object
    sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new infantil.inf_monstrossa());
        }
        catch (EXpextion ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}

private void frozenbtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new infantil.inf_frozen());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void osincriveisbtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new infantil.inf_osincriveis());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void insetobtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new infantil.inf_vidadeinseto());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}