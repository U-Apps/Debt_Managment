using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagment_BusinessLayer
{
    [Flags]
    public enum enUserPermissions
    {
        SuppliersManagemnt = 0b_0000_0001,
        ClientsManagemnt = 0b_0000_0010,
        UsersManagemnt = 0b_0000_0100,
        All = SuppliersManagemnt | ClientsManagemnt | UsersManagemnt
    }
}
