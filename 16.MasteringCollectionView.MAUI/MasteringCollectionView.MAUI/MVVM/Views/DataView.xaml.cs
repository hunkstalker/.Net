using MasteringCollectionView.MAUI.MVVM.ViewModels;

namespace MasteringCollectionView.MAUI.MVVM.Views;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();
	}
}