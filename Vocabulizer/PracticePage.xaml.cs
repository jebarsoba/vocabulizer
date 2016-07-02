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
        }
        async void practice(object sender, EventArgs e)
        {
            string alertTitle = string.Empty;
            string alertBodyText = string.Empty;

            if (string.IsNullOrEmpty(sourceWordText.Text) || string.IsNullOrEmpty(targetWordText.Text))
            {
                alertTitle = "An error has occurred";
                alertBodyText = "You have to enter both words.";

                await this.DisplayAlert(alertTitle, alertBodyText, "Ok");

                return;
            }

            if (string.IsNullOrEmpty(sourceWordText.Text) != string.IsNullOrEmpty(targetWordText.Text))
            {
                alertTitle = "You are wrong!";
                alertBodyText = sourceWordText.Text + " means " + targetWordText.Text + '.';

                await this.DisplayAlert(alertTitle, alertBodyText, "Ok");

                return;
            }
            else
            {
                alertTitle = "Congrats";
                alertBodyText = "Congrats, you are doing right!";

                await this.DisplayAlert(alertTitle, alertBodyText, "Ok");

                return;
            }
        }
    }
}
