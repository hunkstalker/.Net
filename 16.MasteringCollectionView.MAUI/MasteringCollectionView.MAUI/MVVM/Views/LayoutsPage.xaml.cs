using MasteringCollectionView.MAUI.MVVM.ViewModels;

namespace MasteringCollectionView.MAUI.MVVM.Views;

public partial class LayoutsPage : ContentPage
{
	public LayoutsPage()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();
	}
}