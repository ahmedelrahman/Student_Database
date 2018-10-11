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

namespace Student_Database
{
    /// <summary>
    /// Interaction logic for EducationForm.xaml
    /// </summary>
    public partial class EducationForm : Window
    {

        Student temp = new Student(); // creates a temporary student object

        // Indicates that the EducationForm window will have 1 student object passed to it
        public EducationForm(ref Student w)
        {
            InitializeComponent();

            temp = w; // makes temp student object equal to the passed in student object
        }

        // This is responsible of the Submit button
        private void SubmitCommand(object sender, RoutedEventArgs e)
        {
            // indicates the functionality if user enters department
            if (department.SelectedItem != null)
            {
                string myString = ((ComboBoxItem)department.SelectedItem).Content.ToString();
                temp.Department = myString;
            }
            else
            {
                temp.Department = null;
            }
           
            temp.EnrollmentYear = EnrollmentYear.Text; // sets text input of enrollment year equal to enrollmet year student property
            temp.ExpectedGraduation = ExpectedGraduationYear.Text; // sets text input of graduation year equal to graduation year student property

            // indicates the functionality if user enters department
            if (CurrentGPA.SelectedItem != null)
            {
                string myString1 = ((ComboBoxItem)CurrentGPA.SelectedItem).Content.ToString();
                temp.GpA = myString1;
            }
            else
            {
                temp.GpA = null;
            }

            Close();
        }
    }
}
