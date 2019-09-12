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

namespace LearningObjects {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnMakePerson_Click(object sender, RoutedEventArgs e) {
            int a= 5;
            Person firstPerson, secondPerson;
            firstPerson = new Person();
            secondPerson = new Person("Mary", "Muffit");

            firstPerson.FirstName = "Fred";
            firstPerson.LastName = "Alex";
            tbPersonOutput.Text = firstPerson.FirstName + firstPerson.LastName;

            


            firstPerson.DateOfBirth = new DateTime(2019, 12, 25);

        }
    }
}
