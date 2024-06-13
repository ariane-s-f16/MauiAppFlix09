namespace MauiAppFlix;

public partial class acao : ContentPage
{
	public acao()
	{
		InitializeComponent();
	}
	private void clubedalutabtn_Clicked(object 
		sender, EventArgs e)
	{
		try 
		{
			Navigation.PushAsync(new acao.acao_clubedaluta());
		}
		catch( EXpextion ex ) 
		{
			DisplayAlert("OPS!!", ex.Message, "OK");
		}
	} 
}

private void karatekidbtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new acao.acao_karatekid());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void vingadoresultimatobtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new acao.acao_vingadoresultimato());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void ostrezentosbtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new acao.acao_300());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}
