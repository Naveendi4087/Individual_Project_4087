using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Assignment01
{
    public partial class AddStudentWindowVM : ObservableObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string DateOfBirth { get; set; }

        public double GPA { get; set; }
        public BitmapImage SelectedImage { get; set; }
        
        public AddStudentWindowVM()
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
            if (GPA < 0 || GPA > 4)
            {
                MessageBox.Show("GPA value must be between 0 and 4.", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(FirstName!= null && LastName!=null && DateOfBirth!=null)
            {
                var student = new User()
                {
                    Image = SelectedImage,
                    FirstName = FirstName,
                    LastName = LastName,
                    Age = Age,
                    DateOfBirth = DateOfBirth,
                    Gpa = GPA
                };
                MainWindowVM.myUsers.Add(student);
                MessageBox.Show("Student Added");
                MainWindowVM.users.Clear();
                foreach(var user in MainWindowVM.myUsers)
                {
                    MainWindowVM.users.Add(user);
                }

            }


        }
    }
}
