using Microsoft.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBV1;Integrated Security=True;";
        public MainWindow()
        {
            InitializeComponent();
        }
        public bool Autorisation(string a, string b)
        {
            if (a == "admin" && b == "admin")
            {
                return true;
            }
            else
                return false;
        }
        public bool CreateOrder(int a, DateTime b, string c, string d, string e, string f, string g, string h, string i, DateTime j)
        {
            return true;
        }
        public bool DeleteOrder(int a )
        {
            if (a == 1)
                return true;
            else
                return false;
        }

        public bool UpdateOrder(int a, DateTime b, string c, string d, string e, string f, string g, string h, string i, DateTime j)
        {
            if(a == 1)
                return true;
            else
                return false;
        }
        private void Auto_Click(object sender, RoutedEventArgs e)
        {
            Autorization AutoWindow = new Autorization();

            if (AutoWindow.ShowDialog() == true)
            {
                if (AutoWindow.Password == "12345678")
                    MessageBox.Show("Авторизация пройдена");
                else
                    MessageBox.Show("Неверный пароль");
            }
            else
            {
                MessageBox.Show("Авторизация не пройдена");
            }
        }
        private void LoadDataFromDatabase()
        {
            List<Order> items = new List<Order>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM [Order]";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        items.Add(new Order
                        {
                            Id = reader.GetInt32(0),
                            DateStart = reader.GetDateTime(1),
                            Instruments = reader.GetString(2),
                            Typeofproblem = reader.GetString(3),
                            ClientDescription = reader.GetString(4),
                            Client = reader.GetString(5),
                            Worker = reader.GetString(6),
                            WorkerDescription = reader.GetString(7),
                            Status = reader.GetString(8),
                            DateEnd = reader.GetDateTime(9)
                        });
                    }

                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при подключении к базе данных: {ex.Message}");
                }
            }

            itemsListBox.ItemsSource = items;
            itemsListBox.DisplayMemberPath = "Name";
        }

        //Метод для создания новой записи в базе данных
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            /*if (!string.IsNullOrEmpty(inputTextBox.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO YourTable (Name) VALUES (@name)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@name", inputTextBox.Text);
                        command.ExecuteNonQuery();
                        LoadDataFromDatabase(); // Обновляем список
                        inputTextBox.Clear();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Ошибка при вставке данных: {ex.Message}");
                    }
                }
            }*/
        }

        // Метод для редактирования записи
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            //if (itemsListBox.SelectedItem is Order selectedItem && !string.IsNullOrEmpty(inputTextBox.Text))
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        try
            //        {
            //            connection.Open();
            //            string query = "UPDATE YourTable SET Name = @name WHERE Id = @id";
            //            SqlCommand command = new SqlCommand(query, connection);
            //            command.Parameters.AddWithValue("@name", inputTextBox.Text);
            //            command.Parameters.AddWithValue("@id", selectedItem.Id);
            //            command.ExecuteNonQuery();
            //            LoadDataFromDatabase(); // Обновляем список
            //            inputTextBox.Clear();
            //        }
            //        catch (SqlException ex)
            //        {
            //            MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}");
            //        }
            //    }
            //}
        }

        // Метод для удаления записи
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //if (itemsListBox.SelectedItem is Order selectedItem)
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        try
            //        {
            //            connection.Open();
            //            string query = "DELETE FROM YourTable WHERE Id = @id";
            //            SqlCommand command = new SqlCommand(query, connection);
            //            command.Parameters.AddWithValue("@id", selectedItem.Id);
            //            command.ExecuteNonQuery();
            //            LoadDataFromDatabase(); // Обновляем список
            //        }
            //        catch (SqlException ex)
            //        {
            //            MessageBox.Show($"Ошибка при удалении данных: {ex.Message}");
            //        }
            //    }
            //}
        }
    }
}
