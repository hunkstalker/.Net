﻿using BMICalculator.MAUI.MVVM.Views;

namespace BMICalculator.MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new BMIView();
	}

	protected override Window CreateWindow(IActivationState activationState)
	{
		Window window = base.CreateWindow(activationState);

		window.Height = 915;
		window.Width = 420;

		return window;
	}
}
