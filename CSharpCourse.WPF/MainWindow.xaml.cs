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

namespace CSharpCourse.WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Item> _items;

        public MainWindow()
        {
            InitializeComponent();                                    
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            _items = new List<Item>();

            _items.Add(new Item() { Name = "First item", Price = 0.5 });
            _items.Add(new Item() { Name = "Second item", Price = 0.7 });
            _items.Add(new Item() { Name = "Third item", Price = 0.9 });
            _items.Add(new Item() { Name = "Forth item", Price = 1.2 });

            ListBox1.ItemsSource = _items;
        }
    }
}
