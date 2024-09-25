using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HomeApp
{
    public class LoadingPage : ContentPage
    {
        public LoadingPage()
        {
            // Объявим новый текстовый элемент
            Label header = new Label
            {
                Text = $"Запуск нашего первого приложения{Environment.NewLine} на Xamarin...",             // Здесь можно сразу установить стили и шрифт
                Opacity = 0,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 21
            };
            // Можем даже задать анимацию
            header.FadeTo(1, 3000);

            Label label = new Label()
            {
                FontSize = 16,
                Padding = new Thickness(30, 24, 30, 0),
                FormattedText = new FormattedString()
                {
                    Spans =
                    {
                        new Span() { Text = "Learn more at " },
                        new Span() { Text = "https://aka.ms/xamarin-quickstart",
                            FontAttributes = FontAttributes.Bold },
                    }
                }
            };

            // Инициализация свойства Content новым элементом.
            this.Content = header;

            //this.Content = label;

        }
    }

}
