namespace MauiAppFlix.Categoria;

public partial class drama : ContentPage
{
	public drama()
	{
		InitializeComponent();
	}


    private void aculpaedasestrelasbtn_Clicked(object
    sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new drama.drama_aculpaedasestrelas());
        }
        catch (EXpextion ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}

private void comoeuerabtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new drama.drama_comoeueraantesdevc());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void invictusbtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new drama.drama_invictus());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void aesperadeumibtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new drama.drama_aesperadeumi());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}