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

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {
            
            Application1 Person = new Application1();
            Person.Name = txtname.Text;
            //i changed these names but theyre still from when I created them?
            Person.Address = txtaddress.Text;
            Person.ZipCode = int.Parse(txtzip.Text);
            Person.ToString();
            //cant add to listbox
            lstaddress.Items.Add(Person);


        }
    }
}
