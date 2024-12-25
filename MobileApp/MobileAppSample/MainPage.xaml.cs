namespace MobileAppSample;
public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new TasksPage());
    }
    private async void Button_Clicked1(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Notes());
    }
}

