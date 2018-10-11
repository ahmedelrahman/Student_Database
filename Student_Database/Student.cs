using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Database
{
    public class Student
    {
        public string FirstName { get; set; } // generates first name property for the student
        public string LastName { get; set; } // generates last name property for the student
        public string Uid { get; set; } // generates UID property for the student
        public string HomeAddress { get; set; } // generates HomeAddress property for the student
        public string Email { get; set; } // generates Email property for the student
        public string PhoneNumber { get; set; } // generates Phone Number property for the student
        public string BirthDate { get; set; } // generates BirthDate property for the student
        public string Gender { get; set; } // generates Geneder property for the student
        public string Race { get; set; } // generates race property for the student
        public string LearningDisabilities { get; set; } // generates LearningDisabilities property for the student
        public string Department { get; set; } // generates departmentproperty for the student
        public string EnrollmentYear { get; set; } // generates enrollment year property for the student
        public string ExpectedGraduation { get; set; } // generates expected graduation property for the student
        public string GpA { get; set; } // generates GPA property for the student

        public Student() { } 

        // overrides string ToString()
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\nUID: {Uid}\nHome Address: {HomeAddress}\nEmail: {Email}\nPhone Number: {PhoneNumber}\nBirth Date: {BirthDate}\nGender: {Gender}\nRace: {Race}\nLearning Disabilities: {LearningDisabilities}\nDepartment: {Department}\nEnrollment Year: {EnrollmentYear}\nExpected Graduation Date: {ExpectedGraduation}\nGPA: {GpA}\n";
        }
    }
} 