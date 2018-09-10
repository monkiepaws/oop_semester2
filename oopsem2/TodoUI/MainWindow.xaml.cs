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

namespace TodoUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAddTodo_Click(object sender, RoutedEventArgs e)
        {
            string newTodo = SetTodo();

            ListTodo.Items.Add(newTodo);

            TbMessages.Text = "Added!";
        }

        private void BtnDeleteTodo_Click(object sender, RoutedEventArgs e)
        {
            if (ListTodo.SelectedItem == null)
            {
                NoTodoItemSelectedError();
                return;
            }

            ListTodo.Items.RemoveAt(ListTodo.SelectedIndex);

            TbMessages.Text = "Deleted!";
        }

        private void btnUpdateTodo_Click(object sender, RoutedEventArgs e)
        {
            if (ListTodo.SelectedItem == null)
            {
                NoTodoItemSelectedError();
                return;
            }

            string updatedTodo = SetTodo();
            int index = ListTodo.SelectedIndex;
            ListTodo.Items.RemoveAt(index);
            ListTodo.Items.Insert(index, updatedTodo);

            TbMessages.Text = "Updated!";
        }

        private string SetTodo()
        {
            string title = TbNewTitle.Text;
            string description = TbNewDescription.Text;
            return $"{title}\nDescription: {description}";
        }

        private void NoTodoItemSelectedError()
        {
            TbMessages.Text = "Whoops! Select an item first.";
        }

        private void ClearMessages()
        {
            TbMessages.Text = "";
        }
    }
}
