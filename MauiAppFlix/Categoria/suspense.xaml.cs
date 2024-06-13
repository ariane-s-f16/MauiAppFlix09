namespace MauiAppFlix.Categoria;

public partial class suspense : ContentPage
{
	public suspense()
	{
		InitializeComponent();
	}


    private void blairbtn_Clicked(object
    sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new suspense.terror_blair());
        }
        catch (EXpextion ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}

private void omassacrebtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new suspense.terror_omassacredaserra());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void panicobtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new suspense.terror_panico());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void nosbtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new suspense.terror_nos());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}