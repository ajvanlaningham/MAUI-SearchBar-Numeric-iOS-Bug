namespace SearchBarNumKeyboardMauiBug;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
	private void SearchBarSearchButtonPressed(object sender, EventArgs e)
	{
		Console.WriteLine("Search button Pressed");
		count++;
	}
}

