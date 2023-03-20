namespace CodeQuotes.MAUI;

public partial class MainPage : ContentPage
{
	List<string> quotesList = new List<string>();
	Random random = new Random();

	public MainPage()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();
		await LoadMauiAsset();
	}

	async Task LoadMauiAsset()
	{
		using var stream = await FileSystem.OpenAppPackageFileAsync("quotes.txt");
		using var reader = new StreamReader(stream);

		//var contents = reader.ReadToEnd();
		while(reader.Peek() != -1)
		{
			quotesList.Add(reader.ReadLine());
		}
		NewQuote();
	}

	private void BtnGenerateQuote_Clicked(object sender, EventArgs e)
	{
		NewQuote();
	}

	private void NewQuote()
	{
		int index = random.Next(quotesList.Count);
		lblQuote.Text = quotesList[index];
	}
}