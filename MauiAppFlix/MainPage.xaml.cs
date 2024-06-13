namespace MauiAppFlix
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void animacao_Clicked(System.Object sender, System.EventArgs e)
        { 
             try   {
                Navigation.PushAsync(new animacao());
            }
            catch(Exception ex)
            {
                DisplayAlert("ops!!", ex.Message, "OK");
            }
            
        }

        private void acao_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new animacao());
            }
            catch (Exception ex)
            {
                DisplayAlert("ops!!", ex.Message, "OK");
            }

        }

        private void suspense_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new animacao());
            }
            catch (Exception ex)
            {
                DisplayAlert("ops!!", ex.Message, "OK");
            }

        }
    }


}

