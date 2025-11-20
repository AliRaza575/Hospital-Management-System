using SignInSignUpApplication_WindowsForm_.Business_Layer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUpApplication_WindowsForm_.Data_Layer
{
    internal class DL
    {
        private static List <BL> usersList=new List<BL> ();
        public static void AddUsers(BL user)
        {
            usersList.Add(user);
        }
        public static BL signin(BL user)
        {
            foreach (BL storeduser in usersList)
            {
                if (storeduser.getUserName()==user.getUserName() && storeduser.getPassword()==user.getPassword())
                {
                    return storeduser;
                }
            }
            return null;
        }
        public static string ParseData(string record, int field)
        {
            string item = "";
            int comma = 1;
            for(int i=0;i<record.Length;i++)
            {
                if (record[i]==',')
                    {
                    comma++;
                }
                else if(comma==field)
                {
                    item=item +record[i];
                }

             }
            return item;
        }
        public static bool ReadDataFromFile(string path)
        {
            if(File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string record;
                while((record = sr.ReadLine()) != null)
                {
                    string username = ParseData(record, 1);
                    string password = ParseData(record, 2);
                    string role = ParseData(record, 3);
                    BL user = new BL( username,  password, role);
                    AddUsers(user);
                }
                sr.Close();
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static void StoreDataintoFile(string path,BL user)
        {
            StreamWriter fs =new StreamWriter(path,true);
            fs.WriteLine(user.getUserName()+","+user.getPassword()+","+user.getRole());
            fs.Flush();
            fs.Close();
        }
        
    }
}
