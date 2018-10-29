using APIClient;
using APIClient.Models;
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

namespace Week12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TodoClient client { get; } = new TodoClient();
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Btn_Read_Click(object sender, RoutedEventArgs e)
        {
            string text = "";

            if (Tbox_IdInput.Text == "")
            {
                List<TodoItem> response = await client.GetAsync();
                foreach (TodoItem todo in response)
                {
                    text += $"Task ID: {todo.id}\n";
                    text += $"Description: {todo.task}\n\n";
                }
            }
            else
            {
                TodoItem response = await client.GetAsync(Tbox_IdInput.Text);
                text += $"Task ID: {response.id}\n";
                text += $"Description: {response.task}\n\n";
            }
           
            Tb_Response.Text = text;
        }

        private async void Btn_Create_Click(object sender, RoutedEventArgs e)
        {
            TodoItem task = new TodoItem(Tbox_TaskInput.Text);
            var response = await client.PostAsync(task);

            Tb_Response.Text = $"Success!\n" +
                               $"Todo ID: {response.id}\n" +
                               $"Description: {response.task}\n\n";
        }

        private async void Btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            string id = Tbox_IdInput.Text;
            var response = await client.DeleteAsync(id);

            Tb_Response.Text = response;
        }
    }
}
