using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAssignment2._0
{
     public class Profile : INotifyPropertyChanged
    {

        private string username;

        public event PropertyChangedEventHandler? PropertyChanged;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Username)));
            }
        }

        private string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Surname)));
            }
        }

        private string emailAddress;
        public string EmailAddress
        {
            get { return emailAddress; }
            set
            {
                emailAddress = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EmailAddress)));
            }
        }

        private string bio;
        public string Bio
        {
            get { return bio; }
            set
            {
                bio = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bio)));
            }
        }
    }
}
