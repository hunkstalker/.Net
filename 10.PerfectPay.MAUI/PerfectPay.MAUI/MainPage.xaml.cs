namespace PerfectPay.MAUI;

public partial class MainPage : ContentPage
{
	decimal bill;
	int tip;
	int numPersons = 1;

	public MainPage()
	{
		InitializeComponent();
	}

	private void TxtBill_Completed(object sender, EventArgs e)
	{
		bill = decimal.Parse(txtBill.Text);
		CalculateTotal();
	}

	private void CalculateTotal()
	{
		var totalTip = (bill * tip) / 100;
		var tipByPerson = (totalTip / numPersons);
		lbTipByPerson.Text = $"{tipByPerson:C}";

		var subTotal = (bill / numPersons);
		lbSubtotal.Text = $"{subTotal:C}";

		var totalByPerson = (bill + totalTip) / numPersons;
		lbTotal.Text = $"{totalByPerson:C}";
	}

	private void SldTip_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		double increment = 5;
		double newValue = Math.Round(e.NewValue / increment) * increment;
		((Slider)sender).Value = newValue;

		tip = (int)sldTip.Value;
		lbTip.Text = $"Tip: {tip}%";
		CalculateTotal();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		if (sender is Button btn)
		{
			var percentage = int.Parse(btn.Text.Replace("%", ""));
			sldTip.Value = percentage;
		}
	}

	private void BtnMinus_Clicked(object sender, EventArgs e)
	{
		if(numPersons > 1)
		{
			numPersons--;
		}
		lbNoPersons.Text = numPersons.ToString();
		CalculateTotal();
	}

	private void BtnPlus_Clicked(object sender, EventArgs e)
	{
		numPersons++;
		lbNoPersons.Text = numPersons.ToString();
		CalculateTotal();
	}
}

