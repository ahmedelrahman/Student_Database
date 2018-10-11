using System.Windows;

namespace Student_Database
{
    /// <summary>
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        Student temporary = new Student(); // creates a temporary student object

        // Indicates that the AddStudent window will have 1 student object passed to it
        public AddStudent(ref Student n)
        {
            InitializeComponent();

            temporary = n; // makes temporary student object equal to the passed in student object
        }

        // This is responsible of the Add Education Details button
        private void Education(object sender, RoutedEventArgs e)
        {
            temporary.FirstName = FirstName.Text; // sets text input of first name equal to the first name student property
            temporary.LastName = LastName.Text; // sets text input of last name equal to the last name student property
            temporary.Uid = SchoolID.Text; // sets text input of Uid equal to the SchoolID student property
            temporary.HomeAddress = HomeAddress.Text; // sets text input of HomeAddress equal to the HomeAddress student property
            temporary.Email = email.Text; // sets text input of email equal to the email student property
            temporary.PhoneNumber = PhoneNumber.Text; // sets text input of Phone Number equal to the Phone Number student property
            temporary.BirthDate = BirthDate.Text; // sets text input of Birth Date equal to the BirthDate student property
            temporary.Gender = gender.Text; // sets text input of gender equal to the gender student property
            temporary.Race = race.Text; // sets text input of race equal to the race student property
            temporary.LearningDisabilities = LearningDisabilities.Text; // sets text input of Learning Disabilities equal to the Learning Disabilities student property

            EducationForm eform = new EducationForm(ref temporary); // calls the EducationForm window and passes a student variable to it
             
            eform.ShowDialog();
            this.Close();
        }
    }
}
