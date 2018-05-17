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

namespace ToDo
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void saveBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // String for all text
            List<string> all = new List<string>();

            // Get texts in item and put in all
            foreach (ToDoItem item in ToDoStack.Children) {
                all.Add(item.GetTaskName());
            }
            System.IO.File.WriteAllLines(@"D:\todolist.txt",all);
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            // Generate a rectangle
            ToDoItem item = new ToDoItem();
            
            // Put in ToDoStack
            ToDoStack.Children.Add(item);
        }
    }
}
