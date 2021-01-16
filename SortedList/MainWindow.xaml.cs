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

namespace SortedList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Collections.SortedList sortedList = new System.Collections.SortedList();
        public MainWindow()
        {
            InitializeComponent();
        }

        void add(object sender, RoutedEventArgs e){
            try{
            sortedList.Add(key.Text, value.Text);
            MessageBox.Show(key.Text + " : " + value.Text + " has been add.");
            }
            catch{
                MessageBox.Show("Error\nkey: "+key.Text + " has been add.");
            }

            string msg = "Your sortedlist: \n";

            System.Collections.ICollection collction = sortedList.Keys;

            foreach(string key in collction){
                msg = msg + key.ToString() + "  :  " + sortedList[key].ToString() +"\n"; 
            }
            
            MessageBox.Show(msg);
        }
    }
}
