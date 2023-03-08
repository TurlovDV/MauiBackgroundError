using Java.Security;

namespace MauiApp1;

public partial class MainPage : ContentPage
{

	public IServicesTest serviceTest;
	public MainPage(IServicesTest Services_)
	{
		InitializeComponent();
		serviceTest = Services_;
	}

	bool isStart;
    private int i;

    private void OnCounterClicked(object sender, EventArgs e)
	{
		CounterBtn.Text = i++.ToString();
		isStart = !isStart;
		if (isStart)
			serviceTest.Start();
		else
			serviceTest.Stop();
			
	}
}

