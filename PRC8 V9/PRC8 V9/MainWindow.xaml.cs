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

namespace PRC8_V9
{
    //Создать интерфейс - человек. Создать классы – девушка и парень. Классы должны включать конструкторы, функцию для формирования строки информации очеловеке.Определить функцию реакции человека на вновь увиденного другогочеловека. Сравнение производить по фамилии.
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Reaction_Click(object sender, RoutedEventArgs e) //рекция
        {
            result.Clear();
            Male male = new Male(maleName.Text, maleSurname.Text, malePatronymic.Text);
            result.Text = male.GetReaction();
        }

        private void CompareSurname_Click(object sender, RoutedEventArgs e) //сравнение фамилий
        {
            if (maleSurname.Text == string.Empty || femaleSurname.Text == string.Empty)
            {
                MessageBox.Show("Введите фамилии!");
            }
            else
            {
                result.Clear();
                Female male = new Female(maleName.Text, maleSurname.Text, malePatronymic.Text);
                Female female = new Female(femaleName.Text, femaleSurname.Text, femalePatronymic.Text);

                if (female.CompareTo(male) == 1)
                {
                    result.Text = "Фамилия девушки больше, чем у парня";
                }

                if (female.CompareTo(male) == -1)
                {
                    result.Text = "Фамилия парня больше, чем у девушки";
                }

                if (female.CompareTo(male) == 0)
                {
                    result.Text = "Фамилии одинаковые";
                }
            }
        }

        private void MaleInfo_Click(object sender, RoutedEventArgs e) //информация о мужчине
        {
            if (string.IsNullOrEmpty(maleName.Text) || string.IsNullOrEmpty(maleSurname.Text) || string.IsNullOrEmpty(malePatronymic.Text))
            {
                MessageBox.Show("Введите информацию о парне!");
            }
            else
            {
                result.Clear();
                Male male = new Male(maleName.Text, maleSurname.Text, malePatronymic.Text);
                result.Text = male.ShowMaleInfo();
            }
        }

        private void FemaleInfo_Click(object sender, RoutedEventArgs e) //информация о женщине
        {
            if (string.IsNullOrEmpty(femaleName.Text) || string.IsNullOrEmpty(femaleSurname.Text) || string.IsNullOrEmpty(femalePatronymic.Text))
            {
                MessageBox.Show("Введите информацию о парне!");
            }
            else
            {
                result.Clear();
                Female female = new Female(femaleName.Text, femaleSurname.Text, femalePatronymic.Text);
                result.Text = female.ShowInfo();
            }
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Мишин Д. А. ИСП-34", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
