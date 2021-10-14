using ProjectLab.Handler;
using ProjectLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLab.Controller
{
    public class UserController
    {
        public static string Login(string username, string password, bool remember)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "Username and password cannot be empty!\n";
            }

            User u = UserHandler.Login(username, password);

            if (u == null)
            {
                return "Username and password didn't match! Please try again\n";
            }

            else if (u != null)
            {
                HttpContext.Current.Session.Add("User", u);
                if (remember == true)
                {
                    HttpCookie userLogin = new HttpCookie("userLogin");
                    userLogin["Username"] = username;
                    userLogin["Password"] = password;
                    userLogin.Expires = DateTime.Now.AddHours(1);
                    HttpContext.Current.Response.Cookies.Add(userLogin);
                }

                HttpContext.Current.Response.Redirect("~/View/Home/HomePage.aspx");
            }

            return "";
        }

        public static string Register(string username, string password,
            string confPass, string name, string gender, string phone,
            string address)
        {
            string lblMsg = "";
            int flag = 0;
            int phoneInt;

            //username
            if (UserHandler.CheckUsernameIsEmpty(username) == false)
            {
                lblMsg += "Username must be unique! Please choose another username \r\n";
                flag++;
            }

            if (username.Length < 3)
            {
                lblMsg += "Minimal character of username is 3.\r\n";
                flag++;
            }

            //empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confPass) || string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(address))
            {
                lblMsg += "Every box and button cannot be empty!\r\n";
                flag++;
            }

            //password
            if (password.Length < 8)
            {
                lblMsg += "Minimal character of password is 8\r\n";
                flag++;
            }

            if (!confPass.Equals(password))
            {
                lblMsg += "Password and confirm password must exactly the same.\r\n";
                flag++;
            }

            //gender
            if (gender == null)
            {
                lblMsg += "Gender must be chosen\r\n";
                flag++;
            }

            //address
            if (!address.ToLower().Contains("street"))
            {
                lblMsg += "Address must contain the word 'street'\r\n";
            }

            if (flag == 0)
            {
                phoneInt = int.Parse(phone);
                UserHandler.Register(username, password,
                name, gender, phoneInt, address);
                lblMsg = "Successfully registered!\n";
                HttpContext.Current.Response.Redirect("~/View/Login/LoginGuest.aspx");
            }

            return lblMsg;

        }

        public static void Logout()
        {
            HttpContext.Current.Session.Clear();
            if (HttpContext.Current.Request.Cookies["userLogin"] != null)
            {
                HttpContext.Current.Response.Cookies["userLogin"].Expires = DateTime.Now.AddHours(-1);
            }
            HttpContext.Current.Response.Redirect("~/View/Login/HomeLogin.aspx");
        }

        public static string UpdateProfile(User u, string username, string name,
            string gender, string phone, string address)
        {
            string lblMsg = "";
            int flag = 0;
            int phoneInt;

            //username
            if (UserHandler.CheckUsernameIsEmpty(username) == false)
            {
                lblMsg += "Username must be unique! Please choose another username \r\n";
                flag++;
            }

            if (username.Length < 3)
            {
                lblMsg += "Minimal character of username is 3.\r\n";
                flag++;
            }

            //empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(address))
            {
                lblMsg += "Every box and button cannot be empty!\r\n";
                flag++;
            }

            //gender
            if (gender == null)
            {
                lblMsg += "Gender must be chosen\r\n";
                flag++;
            }

            //address
            if (!address.ToLower().Contains("street"))
            {
                lblMsg += "Address must contain the word 'street'\r\n";
            }

            if (flag == 0)
            {
                phoneInt = int.Parse(phone);
                UserHandler.UpdateProfile(u, username,
                name, gender, phoneInt, address);
                lblMsg = "Successfully registered!\n";
                HttpContext.Current.Response.Redirect("~/View/Login/LoginGuest.aspx");
            }

            return lblMsg;
        }

        public static string ChangePass(User u, string old, string newPass, string confPass)
        {
            string lblMsg = "";
            int error = 0;

            if (string.IsNullOrEmpty(old) || string.IsNullOrEmpty(newPass) ||
                string.IsNullOrEmpty(confPass))
            {
                lblMsg += "Each box must be filled!\r\n";
                error++;
            }
            if (old.Equals(u.Password))
            {
                lblMsg += "Old password didn't match with database\r\n";
                error++;
            }
            if (newPass.Length < 5)
            {
                lblMsg += "New password must be longer than 5 characters\r\n";
                error++;
            }
            if (!confPass.Equals(newPass))
            {
                lblMsg += "Confirmation password must be the same with new password\r\n";
                error++;
            }

            if (error == 0)
            {
                lblMsg = "Change succeed\r\n";
                UserHandler.ChangePass(u, newPass);
            }
            return lblMsg;
        }
    }
}