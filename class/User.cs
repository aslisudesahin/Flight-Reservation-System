using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FligthReservationSystem
{
    public abstract class User
    {
        public int UserId { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }

       
        public User(int userId, string userName, string password, string email)
        {
            UserId = userId;
            UserName = userName;
            Password = password;
            Email = email;
        }

       
        protected User() 
        {

        }


        public bool LogIn(string email, string password)
        {
            if (Email == email && Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void LogOut()
        {
            Console.WriteLine("Kullanici  sistemden cikis yapti.");
        }

        public abstract void ViewProfile();

    }

}

