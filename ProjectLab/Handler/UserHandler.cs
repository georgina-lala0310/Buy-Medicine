using ProjectLab.Model;
using ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLab.Handler
{
    public class UserHandler
    {
        public static User Login(string username, string password)
        {
            return UserRepository.Login(username, password);
        }

        public static bool CheckUsernameIsEmpty(string username)
        {
            return UserRepository.CheckUsernameIsEmpty(username);
        }

        public static bool Register(string username, string password,
            string name, string gender, int phone, string address)
        {
            return UserRepository.InsertUserMember(username, password, name, gender,
                phone, address);
        }

        public static bool UpdateProfile(User u, string username,
          string name, string gender, int phone, string address)
        {
            return UserRepository.UpdateProfile(u, username, name, gender,
                phone, address);
        }

        public static bool ChangePass(User u, string newPass)
        {
            return UserRepository.ChangePass(u, newPass);
        }

        public static List<User> GetAllMember()
        {
            return UserRepository.GetAllMember();
        }

        public static bool DeleteMember(int id)
        {
            return UserRepository.DeleteMember(id);
        }

        public static int getUserId()
        {
            return UserRepository.getUserId();
        }
    }
}