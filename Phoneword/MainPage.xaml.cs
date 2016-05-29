using System;
using Xamarin.Forms;

namespace Vocabulizer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnAddToMyList(object sender, EventArgs e)
        {
            string sourceWord = sourceWordText.Text.Trim();
            string targetWord = targetWordText.Text.Trim();

            string alertTitle = "Add Confirmation";
            string alertBodyText = sourceWord + "/" + targetWord;

            if (string.IsNullOrEmpty(sourceWord) || string.IsNullOrEmpty(targetWord))
            {
                alertTitle = "An error has occurred";
                alertBodyText = "You have to enter both words.";
            }

            await this.DisplayAlert(alertTitle, alertBodyText, "Ok");
        }
    }
}