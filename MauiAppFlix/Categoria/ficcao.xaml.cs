namespace MauiAppFlix.Categoria;

public partial class ficcao : ContentPage
{
	public ficcao()
	{
		InitializeComponent();
	}


    private void godzilabtn_Clicked(object
    sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new ficcao.fi_godzila());
        }
        catch (EXpextion ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}

private void extraordinariobtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new ficcao.fi_extraordinario());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void clickbtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new ficcao.fi_click());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void homemdeferrobtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new ficcao.fi_homem_de_ferro());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}