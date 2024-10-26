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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для NewOrder.xaml
    /// </summary>
    public partial class NewOrder : Window
    {
        public NewOrder()
        {
            InitializeComponent();
        }
        public string ItemName { get; private set; } // Переменная для хранения имени элемента

        public NewOrder(string currentName = "")
        {
            InitializeComponent();
            itemIDTextBox.Text = currentName;
            itemDateStartTextBox.Text = currentName;
            itemInstrumentsTextBox.Text = currentName;
            itemTypeofProblemTextBox.Text = currentName;
            itemClientsDescriptionTextBox.Text = currentName;
            itemIDTextBox.Text = currentName;
            itemIDTextBox.Text = currentName;
            itemDateEndTextBox.Text = currentName;
        }

        // Обработка кнопки "OK"
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            //ItemName = itemNameTextBox.Text;
            DialogResult = true; // Устанавливаем результат диалога в true, чтобы показать, что данные были введены
            Close();
        }

        // Обработка кнопки "Отмена"
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false; // Устанавливаем результат диалога в false
            Close();
        }
    }
}
