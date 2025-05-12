namespace CapstoneAppUIMember.Views;

public partial class TestView : ContentPage
{
	public TestView()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
    {
     base.OnAppearing();

     // Set state based on current width
     UpdateVisualState();

     // Always listen for size changes in case screen rotates or resizes
     this.SizeChanged += (s, e) => UpdateVisualState();
    }

    private void UpdateVisualState()
    {
     var orientation = DeviceDisplay.MainDisplayInfo.Orientation;

     if(orientation == DisplayOrientation.Portrait)
        VisualStateManager.GoToState(ResponsiveGrid, "Narrow");
     else
        VisualStateManager.GoToState(ResponsiveGrid, "Normal");
    }
}