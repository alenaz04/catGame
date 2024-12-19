using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Кошачьи_будни.кот
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { // Загружаем изображение z.png
          
            var bitmapImage = new BitmapImage(new Uri("/z.png", UriKind.Relative));

            // Передача изображения на целевую страницу
            var page1 = new Page1(); // Предполагаю, что у тебя уже есть класс Page1
            page1.cat.Source = bitmapImage; // Предположу, что на Page1 есть элемент управления Image с именем 'cat'

            // Переход на новую страницу
            this.NavigationService.Navigate(page1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Загружаем изображение z.png

            var bitmapImage = new BitmapImage(new Uri("/z1.png", UriKind.Relative));

            // Передача изображения на целевую страницу
            var page1 = new Page1(); // Предполагаю, что у тебя уже есть класс Page1
            page1.cat.Source = bitmapImage; // Предположу, что на Page1 есть элемент управления Image с именем 'cat'

            // Переход на новую страницу
            this.NavigationService.Navigate(page1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Загружаем изображение z.png

            var bitmapImage = new BitmapImage(new Uri("/z2.png", UriKind.Relative));

            // Передача изображения на целевую страницу
            var page1 = new Page1(); // Предполагаю, что у тебя уже есть класс Page1
            page1.cat.Source = bitmapImage; // Предположу, что на Page1 есть элемент управления Image с именем 'cat'

            // Переход на новую страницу
            this.NavigationService.Navigate(page1);
        }
    }
}
