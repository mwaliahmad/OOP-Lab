using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem01.BL;
using System.IO;
namespace Problem01.DL
{
    public class UserCRUD
    {
        public static List<User> Users = new List<User>();
        public static void AddUserToList(User U)
        {
            Users.Add(U);
        }
        public static User UserSignIn(User U)
        {
            foreach (var user in Users)
            {
                if (user.GetUsername() == U.GetUsername() && user.GetPassword() == U.GetPassword())
                {
                    return user;
                }
            }
            return null;
        }
        public static string ParseData(string line, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + line[i];
                }
            }
            return item;
        }
        public static bool LoadData(string path)
        {
            if (File.Exists(path))
            {
                StreamReader data = new StreamReader(path);
                string record;
                while ((record = data.ReadLine()) != null)
                {
                    string name = ParseData(record, 1);
                    string pass = ParseData(record, 2);
                    string role = ParseData(record, 3);
                    User U = new User(name, pass, role);
                    AddUserToList(U);
                }
                data.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void DatatoFile(User U, string path)
        {
            StreamWriter data = new StreamWriter(path, true);
            data.WriteLine(U.GetUsername() + "," + U.GetPassword() + "," + U.GetRole());
            data.Flush();
            data.Close();
        }
    }
}
