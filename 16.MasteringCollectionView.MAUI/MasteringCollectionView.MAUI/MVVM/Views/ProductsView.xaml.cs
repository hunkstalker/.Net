using MasteringCollectionView.MAUI.MVVM.ViewModels;

namespace MasteringCollectionView.MAUI.MVVM.Views;

public partial class ProductsView : ContentPage
{
	public ProductsView()
	{
		InitializeComponent();
		BindingContext = new ProductsViewModel();
	}
}