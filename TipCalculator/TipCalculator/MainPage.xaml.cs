namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void FifteenBtn_Clicked(object sender, EventArgs e)
        {
            SliderTipPercent.Value = 15;
        }

        private void TwentyBtn_Clicked(object sender, EventArgs e)
        {
            SliderTipPercent.Value = 20;
        }

        private void DownBtn_Clicked(object sender, EventArgs e)
        {
            //Calcular a gorgeta, arredondando para baixo
           double result = CalculateTip();
           double roundedResult = Math.Floor(result);
           double amount = Convert.ToDouble(ValueEntry.Text.ToString());
           double TotalValue = roundedResult + amount;
            //Exibir a gorjeta
            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = TotalValue.ToString();
        }

        private void UpBtn_Clicked(object sender, EventArgs e)
        {
            //Calcular a gorgeta, arredondando para cima 
            double result = CalculateTip();
            double roundedResult = Math.Ceiling(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double TotalValue = roundedResult + amount;

            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = TotalValue.ToString();
        }

        private double CalculateTip()
        {
            //Receber valor digitado pelo usuário
            //Receber valor da porcentagem para calcular a gorjeta
            //Realizar o cálculo da gorjeta considerando o tipo de arrendondamento
            //Exibir valor final na Label Total

            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double percent = SliderTipPercent.Value;
            
            //Cálculo da gorjeta
            double result = amount * (percent / 100);
            return result;
        }

        private void SliderTipPercent_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            LabelTotalPercent.Text = Math.Round(SliderTipPercent.Value).ToString();
        }
    }

}
