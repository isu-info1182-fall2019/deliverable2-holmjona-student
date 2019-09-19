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
        public MainWindow() {
            InitializeComponent();
        }

        private void BtnMakePerson_Click(object sender, RoutedEventArgs e) {
            int a = 5;
            Person firstPerson, secondPerson;
            //firstPerson = new Person();
            //secondPerson = new Person("Mary", "Muffit");

            //firstPerson.FirstName = "Fred";
            //firstPerson.LastName = "Alex";
            //tbPersonOutput.Text = firstPerson.FirstName + firstPerson.LastName;
            //tbPersonOutput.Text = firstPerson.SaySomething();
            //tbPersonOutput.Text = firstPerson.SayYourName() + "\r\n"  // A
            //    + secondPerson.SayYourName();


            //firstPerson.DateOfBirth = new DateTime(2019, 12, 25);

            Student stud = new Student();
            stud.FirstName = "John";
            stud.StudentID = 14335;

            tbPersonOutput.Text = stud.SayYourName(); // B
            //tbPersonOutput.Text = firstPerson.SayYourName(); // A


            Student sOne = new Student();
            sOne.FirstName = "Govinda";
            Person sTwo = sOne;
            Teacher tOne = new Teacher();
            tOne.FirstName = "Mister";
            Person tTwo = tOne;
            Person tThree = sOne;
          //  Student sThree = new Person();
            //a  = sOne.StudentID;
            //a  = sTwo.StudentID;

            //tbPersonOutput.Text = sOne.SayYourName() + "\r\n" + sTwo.SayYourName()
            //+ "\r\n" + tOne.SayYourName() + "\r\n" + tTwo.SayYourName();

            tbPersonOutput.Text = sOne + "\r\n" + sTwo
            + "\r\n" + tOne + "\r\n" + tTwo.ToString();


            Student sFour = new Student();
            sFour.FirstName = "Sushan";
            Student sFive = sFour.CloneMe();
            sFive.FirstName = "Meshari";

            tbPersonOutput.Text = sFour + "\r\n" + sFive;


            Teacher tFour = new Teacher();
            tFour.FirstName = "Sushan";
            Teacher tFive = tFour.CloneMeReally();
            tFive.FirstName = "Meshari";

            tbPersonOutput.Text = tFour + "\r\n" + tFive;


        }
    }
}
