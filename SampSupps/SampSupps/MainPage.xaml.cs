using SampSupps.ViewModels;

namespace SampSupps;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext= new MainPageViewModel();
	}
}

