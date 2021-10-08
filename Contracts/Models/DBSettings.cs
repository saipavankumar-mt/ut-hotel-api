using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models
{
    public class DBSettings
    {
        public DatabaseLocation DatabaseLocation { get; set; }
        public TableNames TableNames { get; set; }
    }

    public class DatabaseLocation
    {
        public string UsersDatabase { get; set; }

        public string HotelDatabase { get; set; }

        public string HotelInventoryDatabasePrefix { get; set; }

        // "hotel-inventory-2022" - 200 * 365 = 72000 Record
    }

    public class TableNames
    {
        public string SessionTable { get; set; }
        public string UserTable { get; set; }
        public string PasswordRegistryTable { get; set; }
        public string CustomersTable { get; set; }
        public string HotelTable { get; set; }
        public string RoomCategoryTable { get; set; }

    }
}
