namespace MauiAppFlix.Categoria;

public partial class guerra : ContentPage
{
	public guerra()
	{
		InitializeComponent();
	}


    private void chefaobtn_Clicked(object
    sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new guerra.guerra_o_poderoso_chefao());
        }
        catch (EXpextion ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}

private void ateoultimohomembtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new guerra.guerra_ateoultimohomem());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void o1917btn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new guerra.guerra_1917());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void zonabtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new guerra.guerra_zonaderisco());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}