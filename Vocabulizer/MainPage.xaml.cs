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

            foreach (Word w in this.repo.GetAll())
                this.words.Add(w.source + "/" + w.target);

            this.wordList.ItemsSource = this.words;

            practiceButon.Clicked += async (sender, args) =>
             {
                 await Navigation.PushAsync(new PracticePage());
             };
        }

        async void OnAddToMyList(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourceWordText.Text) || string.IsNullOrEmpty(targetWordText.Text))
            {
                string alertTitle = "An error has occurred";
                string alertBodyText = "You have to enter both words.";

                await this.DisplayAlert(alertTitle, alertBodyText, "OK");

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