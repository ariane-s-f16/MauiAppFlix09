namespace MauiAppFlix.Categoria;

public partial class aventura : ContentPage
{
	public aventura()
	{
		InitializeComponent();
	}


    private void carrosbtn_Clicked(object
    sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new aventura.ave_carros());
        }
        catch (EXpextion ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}

private void gato_de_botasbtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new aventura.ave_gatodebotas());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void harrybtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new aventura.ave_harrypotter());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void JurassikParkbtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new aventura.ave_JurassikPark());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}