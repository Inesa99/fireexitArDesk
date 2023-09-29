using NewProject1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
//using System.Text.Json;
//using System.Text.Json;
//using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NewProject
{
    static class FormCommand
    {
        public static string textBoxPass { get; set; }
        public static string textBoxConfPass { get; set; }
        public static string textBoxLogin { get; set; }
        public static string textBoxUser { get; set; }
        public static string textBoxAge { get; set; }
        public static string textBox_pass { get; set; }
        public static string textBox_Login { get; set; }

        public static void Validation()
        {

            bool passLenght = false, isDigit = false, isLow = false, isUpper = false, email = false;
            if (textBoxPass != textBoxConfPass)
            {
                MessageBox.Show("Password and Confirm password don't match!!!!!!!");
            }
            else
            {
                if (textBoxPass.Length > 6 && textBoxPass.Length <= 12)
                {
                    passLenght = true;
                }
                foreach (char i in textBoxPass)
                {
                    if (char.IsDigit(i))
                    {
                        isDigit = true;
                    }
                    if (char.IsUpper(textBoxPass[0]))
                    {
                        isUpper = true;
                    }
                    if (char.IsLower(i))
                    {
                        isLow = true;
                    }
                }
                string r = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
                Regex emailRegex = new Regex(r);
                if (emailRegex.IsMatch(textBoxLogin))
                {
                    email = true;
                }

                if (passLenght == false || isDigit == false || isLow == false || isUpper == false || email == false)
                {
                    MessageBox.Show("Please follow the rules.\nPassword must be 6 to 12 charecters\nPassword must contain a digit\nThe first letter must be uppercase\nThe rest should be lowercase\nEmail name rules must ve followed");
                }
                else
                {
                    User1 user1 = new User1
                    {
                        UserName = textBoxUser,
                        Age = int.Parse(textBoxAge),
                        Login = textBoxLogin,
                        Password = textBoxPass
                    };
                    var opt = new JsonSerializerOptions() { WriteIndented = true };
                    string startupPath = Environment.CurrentDirectory; // project link
                    string projectDirectory = Directory.GetParent(startupPath).Parent.Parent.FullName + @"\TextFile.json"; // project link + json link

                    string json = File.ReadAllText(projectDirectory); // read text
                    var user = System.Text.Json.JsonSerializer.Deserialize<IList<User1>>(json);
                    var checkedUser = true; //5user.Any(u => u.Login == textBoxLogin && u.Password == textBoxPass);
                    if (checkedUser)
                    {
                        MessageBox.Show("There is an account with that login and password");
                    }
                    //else
                    //{
                    //    user.Add(user1);
                    //}

                    File.WriteAllText(projectDirectory, String.Empty); //մտնում է ջսոն ֆայլ և դատարկում

                    string strJson =System.Text.Json.JsonSerializer.Serialize<IList<User1>>(user, opt);

                    using (StreamWriter s = new StreamWriter(projectDirectory)) // streaWriter faileri het e ashxatum isk using@ jnjum e obyekt@ 
                    {

                        s.WriteLine(strJson);


                    }
                    
                    //User u = new User();
                    //u.Show();
                    
                }
            }
        }
        public static bool Deserialization()
        {
            // Deserialization
            var opt = new JsonSerializerOptions() { WriteIndented = true };
            string startupPath = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(startupPath).Parent.Parent.FullName + @"\TextFile.json";

            string json = File.ReadAllText(projectDirectory);
            var b = true;if (b == true)
            {

                DoorControl d = new DoorControl();
                d.Show();
                return true;

            }
            else
            {
                MessageBox.Show("Wrong login or password");
                return false;
            }
        }
    }
}
