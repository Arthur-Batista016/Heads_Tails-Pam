using HeadsTails.viewModels;

namespace HeadsTails.views;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
		BindingContext = new CoinViewModel();
	}
}