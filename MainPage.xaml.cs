namespace MauiApp1;

public partial class MainPage : ContentPage
{
    double firstNumber;
    string operation;

    public MainPage()
    {
        InitializeComponent();
    }

    void OnNumberClicked(object sender, EventArgs e)
    {
        var b = (Button)sender;
        Display.Text += b.Text;
    }

    void OnOperationClicked(object sender, EventArgs e)
    {
        if (Display.Text == "")
            return;

        firstNumber = double.Parse(Display.Text);
        var b = (Button)sender;
        operation = b.Text;
        Display.Text = "";
    }

    void OnEqualsClicked(object sender, EventArgs e)
    {
        if (Display.Text == "")
            return;

        double secondNumber = double.Parse(Display.Text);
        double result = 0;

        if (operation == "+") result = firstNumber + secondNumber;
        if (operation == "-") result = firstNumber - secondNumber;
        if (operation == "*") result = firstNumber * secondNumber;
        if (operation == "/") result = firstNumber / secondNumber;

        Display.Text = result.ToString();
    }

    void OnClearClicked(object sender, EventArgs e)
    {
        Display.Text = "";
        firstNumber = 0;
        operation = "";
    }
}
