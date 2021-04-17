using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace official_pro
{
    public class MyData
    {
        public static List<User> users = new List<User>();
        public static void LoadUsers()
        {
            User user1 = new User();
            user1.Username = "Arian";
            user1.Password = "1234";
            user1.Firstname = "Arian";
            user1.Lastname = "Sadriu";
            user1.Email = "arian.sedriu@gmail.com";
            user1.StatusId = 1;
            users.Add(user1);

            User user2 = new User();
            user2.Username = "Artan";
            user2.Password = "4567";
            user2.Firstname = "Artan";
            user2.Lastname = "Sadriu";
            user2.Email = "artan.sadriu@gmail.com";
            user2.StatusId = 1;
            users.Add(user2);

            User user3 = new User();
            user3.Username = "Beni";
            user3.Password = "1122";
            user3.Firstname = "Beni";
            user3.Lastname = "Sadriu";
            user3.Email = "beni.sadriu@gmail.com";
            user3.StatusId = 2;
            users.Add(user3);

        }
    }
}
