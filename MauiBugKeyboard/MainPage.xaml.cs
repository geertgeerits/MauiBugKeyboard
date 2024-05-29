namespace MauiBugKeyboard
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPageLoaded(object sender, EventArgs e)
        {
            EntNumber.Focus();
        }
    }
}
