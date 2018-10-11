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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        // Makes a temporary Student ObservableCollection. It will be responsible for saving all the objects in the student observable collection that includes all the student objects
        ObservableCollection<Student> tempList = new ObservableCollection<Student>();

        // Makes a temporary Student ObservableCollection. It will be responsible for storing the list generated depending on what is searched for
        ObservableCollection<Student> newlist = new ObservableCollection<Student>();

        // Indicates that the Search window will have 1 list
        public Search( ref ObservableCollection<Student> sList )
        {
            InitializeComponent();

            tempList = sList; // sets the tempList equal to the main observable collection made by the user
        }

        // This is responsible of the functionality of the Search button
        private void Search_button(object sender, RoutedEventArgs e)
        {
            // indicates the functionality if user is searching by first and last name
            if (firstName.Text != null && lastName.Text != null)
            {
                var query = tempList.Where(x => x.FirstName == firstName.Text && x.LastName == lastName.Text);

                foreach (var x in query)
                {
                    newlist.Add(x);
                }
            }

            // indicates the functionality if user is searching by UID
            if (ID.Text != null)
            {
                var query = tempList.Where(x => x.Uid == ID.Text);

                foreach (var x in query)
                {
                    newlist.Add(x);
                }
            }

            // indicates the functionality if user is searching by race
            if (race.Text != null)
            {
                var query = tempList.Where(x => x.Race == race.Text);

                foreach (var x in query)
                {
                    newlist.Add(x);
                }
            }

            // indicates the functionality if user is searching by gender
            if (gender.Text != null)
            {
                var query = tempList.Where(x => x.Gender == gender.Text);

                foreach (var x in query)
                {
                    newlist.Add(x);
                }
            }

            // indicates the functionality if user is searching by Department
            if (Department.SelectedItem != null)
            {
                string myString = ((ComboBoxItem)Department.SelectedItem).Content.ToString();
                IEnumerable<Student> query = tempList.Where(x => x.Department == myString);
                //Console.WriteLine(myString);
                foreach (var x in query)
                {
                    newlist.Add(x);
                }
            }

            // indicates the functionality if user is searching by GPA
            if (GPA.SelectedItem != null)
            {
                string myString = ((ComboBoxItem)GPA.SelectedItem).Content.ToString();
                IEnumerable<Student> query = tempList.Where(x => x.GpA == myString);
                //Console.WriteLine(myString);
                foreach (var x in query)
                {
                    newlist.Add(x);
                }
            }

            // indicates the functionality if user is searching by Learning Disabilities
            if (LearningDisabilities.IsChecked == true)
            {
                IEnumerable<Student> query = tempList.Where(x => x.LearningDisabilities != "");

                foreach (var x in query)
                {
                    newlist.Add(x);
                }
            }

            // calls the SearchResults window and passes the 2 lists to it
            SearchResults results = new SearchResults(ref newlist, ref tempList);
            results.ShowDialog();
            this.Close();
        }
    }
}
