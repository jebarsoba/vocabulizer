using DAL;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Vocabulizer
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> words = new ObservableCollection<string>();
        WordRepository repo = new WordRepository();

        public MainPage()
        {
            InitializeComponent();

            this.wordList.ItemsSource = this.words;
        }

        async void OnAddToMyList(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourceWordText.Text) || string.IsNullOrEmpty(targetWordText.Text))
            {
                string alertTitle = "An error has occurred";
                string alertBodyText = "You have to enter both words.";

                await this.DisplayAlert(alertTitle, alertBodyText, "Ok");

                return;
            }

            this.words.Add(sourceWordText.Text + "/" + targetWordText.Text);

            this.repo.Add(
                new Word()
                {
                    source = sourceWordText.Text,
                    target = targetWordText.Text
                }
            );

            sourceWordText.Text = string.Empty;
            targetWordText.Text = string.Empty;
        }
    }
}