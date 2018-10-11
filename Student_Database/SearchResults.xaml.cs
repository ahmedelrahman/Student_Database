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
using System.Windows.Shapes;

namespace Student_Database
{
    /// <summary>
    /// Interaction logic for SearchResults.xaml
    /// </summary>
    public partial class SearchResults : Window
    {
        // Makes a temporary Student ObservableCollection. It will be responsible for storing the list generated in the search window
        ObservableCollection<Student> tempList = new ObservableCollection<Student>();

        // Makes a temporary Student ObservableCollection. It will be responsible for storing the list with all the student objects entered by the user
        ObservableCollection<Student> tempListforwholeList = new ObservableCollection<Student>();

        // Indicates that the SearchResults window will have 2 lists passed to it
        public SearchResults(ref ObservableCollection<Student> sList, ref ObservableCollection<Student> wList)
        {
            InitializeComponent();

            CollectionOfStudents.ItemsSource = sList; // allows the list generated in the Search Window to be displayed on the listview

            tempList = sList; // sets temporary list equal to the list generated in the search window
            tempListforwholeList = wList; // sets the other temporary list equal to the list with all the student objects

        }

        // This is responsible of the functionality of the AddStudent button
        private void DeleteStudent(object sender, RoutedEventArgs e)
        {
            // makes sure that the list view has an object that is clicked on by the user
            if (CollectionOfStudents.SelectedItem != null)
            {
                // sets myString equal to the string form of the student clicked on by the user
                string myString = CollectionOfStudents.SelectedItem.ToString();

                // loop in charge of removing the clicked clicked item off the main list saving all the students
                for (int i = 0; i < tempListforwholeList.Count; i++)
                {
                    Student Student = tempListforwholeList[i];
                    if (Student.ToString() == myString)
                    {
                        tempListforwholeList.Remove(Student);
                    }
                }

                // in charge of removing the clicked item off the list displayed in the Listview
                tempList.Remove(CollectionOfStudents.SelectedItem as Student);
            }
        }
    }
}
