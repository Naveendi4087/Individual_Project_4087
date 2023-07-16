using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Xml.Linq;

namespace Assignment01
{
    public partial class EditStudentWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string? firstName;


        [ObservableProperty]
        public string? lastName;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public string? dateOfBirth;

        [ObservableProperty]
        public double gpa;

        [ObservableProperty]
        public string? title;

        [ObservableProperty]
        public BitmapImage? selectedImage;

        public User? Student { get; private set; }


        public EditStudentWindowVM(User u, string title)
        {
            Student = u;

            SelectedImage = Student.Image;
            FirstName = Student.FirstName;
            LastName = Student.LastName;
            Age = Student.Age;
            DateOfBirth = Student.DateOfBirth;
            Gpa = Student.Gpa;


        }
        public EditStudentWindowVM()
        {

        }



        [RelayCommand]
        public void UploadPhoto()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            fileDialog.FilterIndex = 1;
            bool? success = fileDialog.ShowDialog();
            if (success == true)
            {
                SelectedImage = new BitmapImage(new Uri(fileDialog.FileName));

                MessageBox.Show("Imgae was successfuly uploded!", "SUCCESFULL!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }



        [RelayCommand]
        public void Save()
        {
            if (Gpa < 0 || Gpa > 4)
            {
                MessageBox.Show("GPA value must be between 0 and 4.", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (Student == null)
            {
                Student = new User()
                {
                    Image = SelectedImage,
                    FirstName = FirstName,
                    LastName = LastName,
                    Age = Age,
                    DateOfBirth = DateOfBirth,
                    Gpa = Gpa
                };


            }
            else
            {
                Student.Image = SelectedImage;
                Student.FirstName = FirstName;
                Student.LastName = LastName;
                Student.Age = Age;
                Student.DateOfBirth = DateOfBirth;
                Student.Gpa = Gpa;

            }
            int index = MainWindowVM.myUsers.IndexOf(Student);
            MainWindowVM.myUsers.RemoveAt(index);
            MainWindowVM.myUsers.Add(Student);
            MainWindowVM.users.Clear();
            foreach (var user in MainWindowVM.myUsers)
            {
                MainWindowVM.users.Add(user);
            }
            MessageBox.Show($"{Student.FirstName} {Student.LastName} was successfuly edited", "EDITED", MessageBoxButton.OK, MessageBoxImage.Information);


        }
    }
}
