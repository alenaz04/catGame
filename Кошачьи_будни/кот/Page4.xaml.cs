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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        private int age; // Возраст котенка
        private Random random;
        private int correctAnswersCount; // Количество правильных ответов подряд
        public Page4()
        {
            InitializeComponent();
            random = new Random();
            correctAnswersCount = 0; // Инициализация счётчика правильных ответов
            ShowNextKitten();
        }

        private void ShowNextKitten()
        {
            age = random.Next(0, 17); // Возраст от 0 до 16 недель (включительно)
            AgeTextBlock.Text = age.ToString();
            ResultTextBlock.Text = "Выберите подходящий корм для котенка.";
            FoodComboBox.SelectedIndex = -1; // Сбросить выбор
        }

        private void FeedButton_Click(object sender, RoutedEventArgs e)
        {
            if (FoodComboBox.SelectedItem is ComboBoxItem selectedFood)
            {
                string selectedFoodText = (string)selectedFood.Content;
                string feedback = GetFeedingFeedback(age, selectedFoodText);
                ResultTextBlock.Text = feedback;

                // Проверка правильного ответа
                if (feedback.StartsWith("Правильно"))
                {
                    correctAnswersCount++; // Увеличиваем счетчик правильных ответов
                    CheckWinCondition();
                }
                else
                {
                    correctAnswersCount = 0; // Сброс счетчика при неправильном ответе
                }
            }
            else
            {
                ResultTextBlock.Text = "Пожалуйста, выберите корм.";
            }
        }

        private string GetFeedingFeedback(int age, string selectedFood)
        {
            if (age <= 4)
            {
                if (selectedFood == "Молоко" || selectedFood == "Заменитель молока")
                    return "Правильно! Котенку необходимо молоко.";
                else
                    return "Неправильно! Котенок должен питаться молоком.";
            }
            else if (age <= 8)
            {
                if (selectedFood == "Влажный корм" || selectedFood == "Заменитель молока")
                    return "Правильно! Котенка можно кормить влажным кормом или заменителем молока.";
                else
                    return "Неправильно! Котенку нужен влажный корм.";
            }
            else if (age <= 12)
            {
                if (selectedFood == "Сухой корм" || selectedFood == "Влажный корм")
                    return "Правильно! Котенку нужно 4-разовое питание.";
                else
                    return "Неправильно! Котенку нужен сухой или влажный корм.";
            }
            else
            {
                if (selectedFood == "Сухой корм")
                    return "Правильно! Котенку нужен сухой корм.";
                else
                    return "Неправильно! Котенку нужен сухой корм.";
            }
        }

        // Проверка условия выигрыша
        private void CheckWinCondition()
        {
            if (correctAnswersCount >= 10)
            {
                // Поздравительное окно
                MessageBox.Show("Поздравляю! Вы прошли игру, дав 10 подряд правильных ответов!", "Выигрыш!", MessageBoxButton.OK, MessageBoxImage.Information);
                // Сбросить счётчик правильных ответов
                correctAnswersCount = 0;
                ShowNextKitten();
                NavigationService.Navigate(new Page1());
            }
        }

        private void NextKittenButton_Click(object sender, RoutedEventArgs e)
        {
            ShowNextKitten();
           
        }
    }
}
