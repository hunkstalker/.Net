using System.ComponentModel;

namespace _12.Hangman.MAUI;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
	#region UI Properties
	public string SpotLight
	{
		get => spotLight; set
		{
			spotLight = value;
			OnPropertyChanged();
		}
	}
	public List<char> Letters
	{
		get => letters; set
		{
			letters = value;
			OnPropertyChanged();
		}
	}
	public string Message
	{
		get => message; set
		{
			message = value;
			OnPropertyChanged();
		}
	}
	public string GameStatus
	{
		get => gameStatus; set
		{
			gameStatus = value;
			OnPropertyChanged();
		}
	}
	public string CurrentImage
	{
		get => currentImage; set
		{
			currentImage = value;
			OnPropertyChanged();
		}
	}
	#endregion

	#region Fields
	public readonly List<string> words = new()
	{
		"PYTHON",
		"JAVASCRIPT",
		"NET",
		"MAUI",
		"CSHARP",
		"MONGODB",
		"SQL",
		"XAML",
		"WORD",
		"EXCEL",
		"POWERPOINT",
		"CODE",
		"COPILOT"
	};

	public List<char> guessed = new();
	public string answer = "";

	private string spotLight;
	private List<char> letters = new();
	private string message;
	private int mistakes = 0;
	private int maxWrong = 6;
	private string gameStatus;
	private string currentImage = "img0.jpg";
	#endregion

	public MainPage()
	{
		InitializeComponent();
		Letters.AddRange("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
		BindingContext = this;
		PickWord();
		CalculateWord(answer, guessed);
	}

	#region Game Engine
	private void PickWord()
	{
		answer = words[new Random().Next(0, words.Count)];
	}

	private void CalculateWord(string answer, List<char> guessed)
	{
		var temp = answer.Select(x => guessed.IndexOf(x) >= 0 ? x : '_').ToArray();
		SpotLight = string.Join(' ', temp);
	}

	private void UpdateStatus()
	{
		GameStatus = $"Errors: {mistakes} of {maxWrong}";
	}
	#endregion

	private void Btn_Clicked(object sender, EventArgs e)
	{
		if (sender is Button btn)
		{
			string letter = btn.Text;
			btn.IsEnabled = false;
			Handle_Guess(letter[0]);
		}
	}

	private void Handle_Guess(char letter)
	{
		if (guessed.IndexOf(letter) == -1)
		{
			guessed.Add(letter);
		}

		if (answer.Contains(letter))
		{
			CalculateWord(answer, guessed);
			CheckIfGameWon();
		}
		else
		{
			mistakes++;
			UpdateStatus();
			CheckIfGameLost();
			CurrentImage = $"img{mistakes}.jpg";
		}
	}

	private void CheckIfGameLost()
	{
		if(mistakes == maxWrong)
		{
			Message = "You lost!";
			DisableLetters();
		}
	}

	private void CheckIfGameWon()
	{
		if (SpotLight.Replace(" ", "") == answer)
		{
			Message = "You win!";
			DisableLetters();
		}
	}

	private void DisableLetters()
	{
		foreach(var children in FlexLayoutContainers.Children)
		{
			if(children is Button btn)
			{
				btn.IsEnabled = false;
			}
		}
	}

	private void EnableLetters()
	{
		foreach (var children in FlexLayoutContainers.Children)
		{
			if (children is Button btn)
			{
				btn.IsEnabled = true;
			}
		}
	}

	private void BtnReset_Clicked(object sender, EventArgs e)
	{
		mistakes = 0;
		guessed = new List<char>();
		CurrentImage = "img0.jpg";
		PickWord();
		CalculateWord(answer, guessed);
		Message = "";
		UpdateStatus();
		EnableLetters();
	}
}