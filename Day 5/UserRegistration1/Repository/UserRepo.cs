using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistration1.Model;
using UserRegistration1.Repository;

namespace UserRegistration1.Repository
{
    internal class UserRepo : IUserRepo, IFile1
    {
        List<User> users = new List<User>();
        public UserRepo()
        {
            users = new List<User>();
        }

        public bool IsRegister(string username, string filename)
        {
            bool isAvailable = false;
            using (StreamReader sr = new StreamReader(filename))
            {
                string rowline;
                while ((rowline = sr.ReadLine()) != null)
                {
                    string[] rowvalues = rowline.Split(',');
                    foreach (string value in rowvalues)
                    {
                        if (value == username)
                        {
                            isAvailable = true;
                            break;
                        }
                    }

                }
            }return isAvailable;
        }

        public List<string> ReadData(string filename)
        {
            List<string> rowVal = new List<string>();
            using (StreamReader sr = new StreamReader(filename))
            {
                string rowline;
                while ((rowline = sr.ReadLine()) != null)
                {
                    rowVal.Add(rowline);
                }
                return rowVal;
            }

        }

        public bool Register(User user)
        {
            users.Add(user);
            string filename = "userdata.txt";
            bool Exists = IsRegister(user.Name,filename);
            if (Exists)
            {
                return false;
            }
            else {
                WriteData(user, filename);
                return true;
            }
}

        public void WriteData(User user, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.Write($"{user}");
            }
        }

       
    }
}

   

