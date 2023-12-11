using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebtManagment_DataAccessLayer;
using System.Drawing;

namespace DebtManagment_BusinessLayer
{
    // this class to provide access to a global user
    public static class ApplicationContext
    {
        // global current user
        public static clsUser CurrentUser { get; set; }

        // current currency

        public static string CampanyName { get; set; }
        public static string CampanyDes { get; set; }
        public static Image CampanyLogo { get; set; }


        // Batabase Settings

        public static void SetDBSettings(string Server, string UserID, string Password)
        {
            clsDataAccessSettings.Server = Server;
            clsDataAccessSettings.User_ID = UserID;
            clsDataAccessSettings.Password = Password;

        }
        public static string[] GetDBSettings()
        {
            return new string[] { clsDataAccessSettings.Server, clsDataAccessSettings.User_ID, clsDataAccessSettings.Password };
        }
        public static bool TakeBackup()
        {
            return clsDataAccessSettings.BackUp();
        }
        public static bool Restore()
        {
            return clsDataAccessSettings.restore();
        }
    }
}
