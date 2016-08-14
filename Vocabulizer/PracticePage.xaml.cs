using DAL;
using System;
using System.Linq;
using Xamarin.Forms;

namespace Vocabulizer
{
    public partial class PracticePage : ContentPage
    {
        WordRepository repo = new WordRepository();
        string sourceWordToPlay = null;
        string targetWordToPlay = null;

        public PracticePage()
        {
            InitializeComponent();

            Word word = new WordRandomizer(this.repo.GetAll().ToList<Word>()).GetRandomWord();
            this.sourceWordToPlay = word.source;
            this.targetWordToPlay = word.target;

            sourceWordText.Text = this.sourceWordToPlay;
        }

        async void OnPractice(object sender, EventArgs e)
        {
            string alertTitle = string.Empty;
            string alertBodyText = string.Empty;

            if (string.IsNullOrEmpty(targetWordText.Text) || string.IsNullOrEmpty(this.targetWordToPlay))
            {
                alertTitle = "An error has occurred";
                alertBodyText = "You have to enter both words.";

                await this.DisplayAlert(alertTitle, alertBodyText, "Ok");

                return;
            }

            string userEnterWord = targetWordText.Text.Trim();

            if (userEnterWord.ToLower() != this.targetWordToPlay.ToLower())
            {
                alertTitle = "You are wrong!";
                alertBodyText = this.sourceWordToPlay + " means " + this.targetWordToPlay + '.';

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