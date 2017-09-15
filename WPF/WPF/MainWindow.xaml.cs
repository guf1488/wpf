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
using System.Collections.ObjectModel;

namespace WPF
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Computer> L = new List<Computer>()
        {
            new Computer("mon1", "proc1", 12),
            new Computer("mon2", "proc2", 22),
            new Computer("mon3", "proc3", 32)
        };

        public MainWindow()
        {

            //разработать программу на с# WPF.
            //создайте коллекцию обьектов класса Computer(Monitor, Processor,Memory).
            //Сделайте привязку к dataGridView,но только двух полей
            
            InitializeComponent();

            dataGrid1.ItemsSource = L;

            //dataGrid1.Columns.Add();
        }
    }
}
