namespace MauiAppFlix.Categoria;

public partial class comedia : ContentPage
{
	public comedia()
	{
		InitializeComponent();
	}


    private void opequeninobtn_Clicked(object
    sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new comedia.co_opequenino());
        }
        catch (EXpextion ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}

private void asbranquelasbtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new comedia.co_asbranquelas());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void gentegrandebtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new comedia.co_gente_grande());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void todomundoempanicobtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new comedia.co_todomundoempanico());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}