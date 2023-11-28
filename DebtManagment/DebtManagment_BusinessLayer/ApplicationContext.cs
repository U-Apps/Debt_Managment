using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagment_BusinessLayer
{
    // this class to provide access to a global user
    public static class ApplicationContext
    {
        // global current user
        public static clsUser CurrentUser { get; set; }
    }
}
