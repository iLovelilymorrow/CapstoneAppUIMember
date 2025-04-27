namespace CapstoneAppUIMember.Views;

public partial class ReceiptsView : ContentPage
{
	public ReceiptsView()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
	 var frame = (Frame)sender;

    
     await frame.ScaleTo(0.95, 70, Easing.CubicIn);
     await frame.ScaleTo(1, 70, Easing.CubicOut);

    
     await frame.FadeTo(0.6, 10);
     await frame.FadeTo(1, 100);
    }
}