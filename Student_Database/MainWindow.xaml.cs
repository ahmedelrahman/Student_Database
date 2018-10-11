using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Student_Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Makes the Student List of type ObservableCollection. It stores all the students added on the application
        public ObservableCollection<Student> StudentList = new ObservableCollection<Student>();


        public MainWindow()
        {
            InitializeComponent();
        }

        // This is responsible of the functionality of the AddStudent button
        private void AddStudent (object sender, RoutedEventArgs e)
        {
            Student n_student = new Student(); // creates a new student object
            AddStudent s = new AddStudent(ref n_student); // creates the AddStudent Window and passes the student object to it
            s.ShowDialog(); // displays the newly made AddStudent window
            StudentList.Add(n_student); // adds the student to the list after the user fills out their properties on different windows on this application

        }

        // This is responsible of the functionality of the Search button
        private void Search_button_Click(object sender, RoutedEventArgs e)
        {
            
            Search searchwindow = new Search(ref StudentList); // creates the Search Window and passes the student the student observablecollection to it

            searchwindow.ShowDialog(); // displays the newly made Search window

        }

        // This is responsible of the functionality of the Delete button
        private void Delete(object sender, RoutedEventArgs e)
        {
            Search searchwindow = new Search(ref StudentList); // creates the Search Window and passes the student the student observablecollection to it

            searchwindow.ShowDialog(); // displays the newly made Search window
        }
    }
}
