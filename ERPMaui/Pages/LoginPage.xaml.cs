using ERPMaui.Services;

namespace ERPMaui.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
	private async void BtnLogin_Clicked (object sender, EventArgs e)
	{
		var response = await LoginService.Login(UserName.Text, Password.Text);
		if (response)
		{
            Application.Current.MainPage = new MainPage();
        }
        else
		{
            await DisplayAlert("", "Invalid username or password", "Cancel");
        }

	}



}