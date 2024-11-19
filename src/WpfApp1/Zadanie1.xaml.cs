using System.Collections.Generic;
using System.Windows;

namespace WpfApp1
{
    public partial class Zadanie1 : Window
    {
        private Dictionary<string, string> translate = new Dictionary<string, string>
        {
            { "солнце", "sun" },
            { "дождь", "rain" },
            { "снег", "snow" },
            { "ветер", "wind" },
            { "облако", "cloud" },
            { "туман", "fog" },
            { "гроза", "thunderstorm" },
            { "тепло", "warmth" },
            { "холод", "cold" },
            { "влажность", "humidity" }
        };
        public Zadanie1()
        {
            InitializeComponent();
        }
        private void TranslateWord(object sender, RoutedEventArgs e)
        {
            string input = InputWord.Text.ToLower();
            if (translate.TryGetValue(input, out string translation))
            {
                OutputTranslation.Text = translation;
            }
            else
            {
                OutputTranslation.Text = "Такого слова нет.";
            }
        }
    }
}