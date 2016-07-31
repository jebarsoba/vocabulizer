using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Vocabulizer
{
    public partial class PracticePage : ContentPage
    {
        public PracticePage()
        {
            InitializeComponent();
            Title = "asas";
        }


        async void practice(object sender, EventArgs e)
        {
            string alertTitle = string.Empty;
            string alertBodyText = string.Empty;

            List<string> words = WordRepository.GetAll().ToList();
            //string targetWordToPlay = words[0].Substring(0, words[0].IndexOf("/") - 1);
            //string sourceWordToPlay = words[0].Substring(words[0].IndexOf("/") + 1, words[0].Length - 1);

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
