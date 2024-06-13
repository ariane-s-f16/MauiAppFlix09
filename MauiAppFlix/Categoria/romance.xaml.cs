namespace MauiAppFlix.Categoria;

public partial class romance : ContentPage
{
	public romance()
	{
		InitializeComponent();
	}


    private void elaedmsbtn_Clicked(object
    sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new romance.ro_elaedms());
        }
        catch (EXpextion ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}

private void o365btn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new romance.ro_365());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void yournamebtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new romance.ro_yourname());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}

private void comosefossebtn_Clicked(object
        sender, EventArgs e)
{
    try
    {
        Navigation.PushAsync(new romance.ro_comosefosse());
    }
    catch (EXpextion ex)
    {
        DisplayAlert("OPS!!", ex.Message, "OK");
    }
}