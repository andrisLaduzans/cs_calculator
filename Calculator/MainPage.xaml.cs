using Engine;
namespace Calculator;

public partial class MainPage : ContentPage
{
    Engine.Calc calc = new Engine.Calc();

    string labelTxt = " ";

    public MainPage()
	{
		InitializeComponent();
		LabelTxt.Text = this.labelTxt;
	}

    private void OnClick(object sender, EventArgs e)
    {
        string btnEnum = (sender as Button).ClassId;
        
        labelTxt = this.calc.handleInput(btnEnum);
        LabelTxt.Text = labelTxt;        
    }
}
