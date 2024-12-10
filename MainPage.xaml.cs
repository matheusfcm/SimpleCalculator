namespace SimpleCalculator;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void Calculate15PercentTip(object sender, EventArgs e) 
    {
        CalculateTip(0.15);
        
    }
    private void Calculate20PercentTip(object sender, EventArgs e)
    {
        
        CalculateTip(0.20);
    }
    private void Calculate25PercentTip(object sender, EventArgs e)
    {
        CalculateTip(0.25);
        
    }

    private void CalculateTip(double tipPercentage)
    {
        double billAmount = double.TryParse(txtBillAmount.Text, out double parsedvalue) ? parsedvalue : 0;

        double tipAmount = billAmount * tipPercentage;
        double totalResult = billAmount + tipAmount;

        lblTipResult.Text = $"Tip :  ${tipAmount:F2}";
        lblTotalResult.Text = $"Total :  ${totalResult:F2}";

    }
    //i dont have audio i am in the school computer however here is my code thank you
}