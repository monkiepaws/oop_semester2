using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
using APIClient;
using TMM.WebAPI.Models;

namespace TMM.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public StudentClient studentClient { get; } = new StudentClient();
        public SessionClient sessionClient { get; } = new SessionClient();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Btn_View_Click(object sender, RoutedEventArgs e)
        {
            switch (Combo_View.SelectionBoxItem)
            {
                case "Student":
                    await ViewStudents();
                    break;
                case "Session":
                    await ViewSessions();
                    break;
                default:
                    break;
            }
        }

        private async void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            if (DataView.SelectedItem.GetType() == typeof(Student))
            {
                await AddStudent();
            }
            else if (DataView.SelectedItem.GetType() == typeof(Session))
            {
                await AddSession();
            }

            DataView.Items.Refresh();
        }

        private async void Btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            if (DataView.SelectedItem.GetType() == typeof(Student))
            {
                await EditStudent();
            }
            else if (DataView.SelectedItem.GetType() == typeof(Session))
            {
                await EditSession();
            }
            else
            {
                return;
            }
        }

        private async void Btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataView.SelectedItem.GetType() == typeof(Student))
            {
                await DeleteStudent();
            }
            else if (DataView.SelectedItem.GetType() == typeof(Session))
            {
                await DeleteSession();
            }

            DataView.Items.Refresh();
        }

        private async Task ViewStudents()
        {
            DataView.ItemsSource = await studentClient.GetAsync();
        }

        private async Task ViewSessions()
        {
            DataView.ItemsSource = await sessionClient.GetAsync();
        }

        private async Task EditStudent()
        {
            Student student = (Student)DataView.SelectedItem;

            if (!IsValidStudent(student))
            {
                return;
            }

            Student response = await studentClient.PutAsync(student);
            MessageBox.Show($"Student {student.FirstName} {student.LastName} successfully changed", "Edit", MessageBoxButton.OK, MessageBoxImage.Information);
            return;
        }

        private async Task EditSession()
        {
            Session session = (Session)DataView.SelectedItem;

            if (!IsValidSession(session))
            {
                return;
            }

            Session response = await sessionClient.PutAsync(session);
            MessageBox.Show($"Session {session.Name} at {session.Location} successfully changed", "Edit", MessageBoxButton.OK, MessageBoxImage.Information);
            return;
        }

        private async Task AddStudent()
        {
            Student student = (Student)DataView.SelectedItem;

            if (!IsValidStudent(student))
            {
                return;
            }

            Student response = await studentClient.PostAsync(student);
            List<Student> list = (List<Student>)DataView.ItemsSource;
            int lastAdded = list.FindIndex(s => s.Id == student.Id);
            list[lastAdded] = response;
            DataView.ItemsSource = list;
            MessageBox.Show($"Student {response.FirstName} {response.LastName} successfully added", "Add", MessageBoxButton.OK, MessageBoxImage.Information);
            return;
        }

        private async Task AddSession()
        {
            Session session = (Session)DataView.SelectedItem;

            if (!IsValidSession(session))
            {
                return;
            }

            Session response = await sessionClient.PostAsync(session);
            List<Session> list = (List<Session>)DataView.ItemsSource;
            int lastAdded = list.FindIndex(s => s.Id == session.Id);
            list[lastAdded] = response;
            DataView.ItemsSource = list;
            MessageBox.Show($"Session {response.Name} at {response.Location} successfully added", "Add", MessageBoxButton.OK, MessageBoxImage.Information);
            return;
        }

        private async Task DeleteStudent()
        {
            Student student = (Student)DataView.SelectedItem;
            string response = await studentClient.DeleteAsync(student.Id);
            List<Student> list = (List<Student>)DataView.ItemsSource;
            list.Remove(student);
            DataView.ItemsSource = list;
            MessageBox.Show($"Student {student.FirstName} {student.LastName} successfully deleted", "Delete", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private async Task DeleteSession()
        {
            Session session = (Session)DataView.SelectedItem;
            string response = await sessionClient.DeleteAsync(session.Id);
            List<Session> list = (List<Session>)DataView.ItemsSource;
            list.Remove(session);
            DataView.ItemsSource = list;
            MessageBox.Show($"Session {session.Name} at {session.Location} successfully deleted", "Delete", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private bool IsValidStudent(Student student)
        {
            try
            {
                if (DateTime.Now <= student.DateOfBirth)
                {
                    throw new ValidationFailureException($"{student.DateOfBirth} is not a valid date.");
                }
                MailAddress email = new MailAddress(student.Email);
                return true;
            }
            catch (ValidationFailureException error)
            {
                MessageBox.Show($"Could not add Student\n\n{error.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Could not add Student\n\n{error.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
        }

        private bool IsValidSession(Session session)
        {
            try
            {
                if (DateTime.Now > session.SessionStartTime || DateTime.Now > session.SessionEndTime || (session.SessionStartTime >= session.SessionEndTime))
                {
                    throw new ValidationFailureException($"{session.SessionStartTime} or {session.SessionEndTime} is not a valid date.");
                }
                return true;
            }
            catch (ValidationFailureException error)
            {
                MessageBox.Show($"Could not add Session\n\n{error.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Could not add Session\n\n{error.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
        }
    }
}
