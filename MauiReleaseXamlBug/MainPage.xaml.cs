namespace MauiReleaseXamlBug
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new TestPage());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.ToString(), "OK");
                App.ExceptionContent = ex.ToString();
            }
        }

        private void ShowErrorButton_Clicked(object sender, EventArgs e)
        {
            ErrorLabel.Text = App.ExceptionContent;
        }
    }

}
