namespace MauiAppFlix.Categoria;

public partial class animacao : ContentPage
{
	public animacao()
	{
		InitializeComponent();
	}

    private void riobtn_Clicked(object
    sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new animacao.ani_rio());
        }
        catch (EXpextion ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}

private void kung_fu_pandabtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new animacao.ani_kung_fu_panda());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void toy_storybtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new animacao.ani_toy_story());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void dinissaurobtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new animacao.ani_o_bom_dinossauro());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

