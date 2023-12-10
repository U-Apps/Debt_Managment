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
        AddUpdateUsers      = 0b_0000_0001,
        DeleteUsers         = 0b_0000_0010,
        ShowUsersInfo       = 0b_0000_0100,
        AddUpdateClients    = 0b_0000_1000,
        DeleteCliets        = 0b_0001_0000,
        AddUpdateSuppliser  = 0b_0010_0000,
        DeleteSuppliser     = 0b_0100_0000,

        All = AddUpdateUsers | DeleteUsers | ShowUsersInfo | AddUpdateClients | DeleteCliets | AddUpdateSuppliser | DeleteSuppliser
    }
}
