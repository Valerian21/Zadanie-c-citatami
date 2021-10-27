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
using System.Windows.Shapes;

namespace Quote
{
    /// <summary>
    /// Логика взаимодействия для Izbrannoe.xaml
    /// </summary>
    public partial class Izbrannoe : Window
    {
        DataClass db = new DataClass();

        public Izbrannoe()
        {
            InitializeComponent();
            db.CreateStrConnection();
            DGAUO.ItemsSource = db.Grquote();
        }
      


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ass = new MainWindow();
            ass.Show();
            this.Hide();
        }
    }
}
