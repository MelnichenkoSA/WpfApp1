using System.Diagnostics.Metrics;
using System.Windows.Controls;
using WpfApp1;
namespace TestProject1
{
    public class UnitTest1
    {
        [WpfFact]
        public void AutorizationTestTrue()
        {
            var test = new MainWindow();

            string login = "admin";
            string password = "admin";

            Assert.True(test.Autorisation(login, password));
        }
        [WpfFact]
        public void AutorizationTestFalse()
        {
            var test = new MainWindow();

            string login = "NOTadmin";
            string password = "NOTadmin";

            Assert.False(test.Autorisation(login, password));
        }
        [WpfFact]
        public void CreateTest()
        {
            var test = new MainWindow();

            int ID = 2;
            DateTime DateStart = new DateTime();
            string Instruments = "qwerty";
            string Typeofproblem = "qwerty";
            string ClientDescription = "qwerty";
            string Client = "qwerty";
            string Worker = "qwerty";
            string WorkerDescription = "qwerty";
            string Status = "Выполнено";
            DateTime DateEnd = new DateTime();

            Assert.True(test.CreateOrder(ID, DateStart, Instruments, Typeofproblem, ClientDescription, Client, Worker, WorkerDescription, Status, DateEnd));
        }
        [WpfFact]
        public void UpdateTestTrue()
        {
            var test = new MainWindow();

            int ID = 2;
            DateTime DateStart = new DateTime();
            string Instruments = "qwertyqwerty";
            string Typeofproblem = "qwertyqwerty";
            string ClientDescription = "qwertyqwerty";
            string Client = "qwertyqwerty";
            string Worker = "qwertyqwerty";
            string WorkerDescription = "qwertyqwerty";
            string Status = "Выполнено";
            DateTime DateEnd = new DateTime();

            Assert.True(test.CreateOrder(ID, DateStart, Instruments, Typeofproblem, ClientDescription, Client, Worker, WorkerDescription, Status, DateEnd));
        }
        [WpfFact]
        public void UpdateTestFalse()
        {
            var test = new MainWindow();

            int ID = 100;
            DateTime DateStart = new DateTime();
            string Instruments = "qwertyqwerty";
            string Typeofproblem = "qwertyqwerty";
            string ClientDescription = "qwertyqwerty";
            string Client = "qwertyqwerty";
            string Worker = "qwertyqwerty";
            string WorkerDescription = "qwertyqwerty";
            string Status = "Выполнено";
            DateTime DateEnd = new DateTime();

            Assert.True(test.CreateOrder(ID, DateStart, Instruments, Typeofproblem, ClientDescription, Client, Worker, WorkerDescription, Status, DateEnd));
        }
        [WpfFact]
        public void DeleteTestTrue()
        {
            var test = new MainWindow();

            int ID = 1;

            Assert.True(test.DeleteOrder(ID));
        }
        [WpfFact]
        public void DeleteTestFalse()
        {
            var test = new MainWindow();

            int ID = 100;

            Assert.False(test.DeleteOrder(ID));
        }
    }
}