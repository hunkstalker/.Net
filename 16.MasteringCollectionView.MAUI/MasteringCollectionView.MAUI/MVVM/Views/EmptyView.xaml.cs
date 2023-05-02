namespace MasteringCollectionView.MAUI.MVVM.Views;

public partial class EmptyView : ContentPage
{
	public EmptyView()
	{
		InitializeComponent();
	}

	private void Switch_Toggled(object sender, ToggledEventArgs e)
	{
		var IsToggled = e.Value;
		collectionView.EmptyView = IsToggled ? Resources["NoResultsView"] : Resources["ConnectivityIssue"];
	}
}