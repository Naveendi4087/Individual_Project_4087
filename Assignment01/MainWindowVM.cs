using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Assignment01
{
    public partial class MainWindowVM : ObservableObject
    {
        public static List<User> myUsers;
        [ObservableProperty]
        public static ObservableCollection<User> users;

        [ObservableProperty]
        public User? selectedUser = null;

        [RelayCommand]
        public void DeleteStudent()
        {
            if (SelectedUser != null)
            {
                string name = SelectedUser.FirstName;
                var result = MessageBox.Show($"Are you sure you want to delete {name}?","CONFIRM DELETION",MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(result == MessageBoxResult.Yes)
                {
                    Users.Remove(SelectedUser);
                    MessageBox.Show($"{name} was successfuly deleted", "DELETED", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a student before deleting", "WARNING!", MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        [RelayCommand]
        public void AddStudent()
        {
            AddStudentWindow window = new AddStudentWindow();
            window.ShowDialog();

        }

        [RelayCommand]
        public void EditStudent()
        {
            if (SelectedUser != null)
            {
                
                string name = SelectedUser.FirstName;
                var result = MessageBox.Show($"Are you sure you want to edit {name}?", "CONFIRMATION", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    var window = new EditStudentWindow(SelectedUser, "EDIT STUDENT WINDOW");
                    window.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a student before editing", "WARNING!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }



        public MainWindowVM()
        {
            myUsers = new List<User>();
            BitmapImage image1 = new BitmapImage(new Uri("/Images/1.png", UriKind.Relative));
            myUsers.Add(new User(image1, "John", "Christoper", 25, "12/02/1998", 2));
            BitmapImage image2 = new BitmapImage(new Uri("/Images/2.png", UriKind.Relative));
            myUsers.Add(new User(image2, "Dave", "Stevenson", 26, "04/05/1997", 3));
            BitmapImage image3 = new BitmapImage(new Uri("/Images/3.png", UriKind.Relative));
            myUsers.Add(new User(image3, "Harry", "Robinson", 27, "10/10/1996", 3));
            BitmapImage image4 = new BitmapImage(new Uri("/Images/4.png", UriKind.Relative));
            myUsers.Add(new User(image4, "Jenny", "Thompson", 23, "04/12/2000", 2));
            BitmapImage image5 = new BitmapImage(new Uri("/Images/5.png", UriKind.Relative));
            myUsers.Add(new User(image5, "Ron", "Wingrave", 25, "14/11/1998", 3));
            Users = new ObservableCollection<User>(myUsers);

        }

    }

    
}
