using DAL;
using System;
using Xamarin.Forms;

namespace Vocabulizer
{
    public partial class PracticePage : ContentPage
    {
        WordRepository repo = new WordRepository();

        public PracticePage()
        {
            InitializeComponent();
            Title = "asas";
        }

        async void practice(object sender, EventArgs e)
        {
            string alertTitle = string.Empty;
            string alertBodyText = string.Empty;

            string sourceWordToPlay = "1234";
            string targetWordToPlay = "5678";

            string userEnterWord = targetWordText.Text.Trim();

            if (string.IsNullOrEmpty(userEnterWord) || string.IsNullOrEmpty(targetWordToPlay))
            {
                alertTitle = "An error has occurred";
                alertBodyText = "You have to enter both words.";

                await this.DisplayAlert(alertTitle, alertBodyText, "Ok");

                return;
            }

            if (userEnterWord.ToLower() != targetWordToPlay.ToLower())
            {
                alertTitle = "You are wrong!";
                alertBodyText = sourceWordToPlay + " means " + targetWordToPlay + '.';

                await this.DisplayAlert(alertTitle, alertBodyText, "Ok");

                return;
            }
            else
            {
                alertTitle = "Congrats";
                alertBodyText = "You are doing right!";

                await this.DisplayAlert(alertTitle, alertBodyText, "Ok");

                return;
            }
        }
    }
}