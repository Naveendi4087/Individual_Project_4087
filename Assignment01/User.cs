using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Assignment01
{
    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? DateOfBirth { get; set; }
        public double Gpa { get; set; }
        public BitmapImage? Image { get; set; }
        public string ImagePath
        {
            get { return $"/Images/{Image}"; }
        }

        public User()
        {
        }
        public User(BitmapImage image, string firstName, string lastName, int age, string dateOfBirth, double gpa)
        {
            Image = image;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            DateOfBirth = dateOfBirth;
            Gpa = gpa;

        }


    }
}
