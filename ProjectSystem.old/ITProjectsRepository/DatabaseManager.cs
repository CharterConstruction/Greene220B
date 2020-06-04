using System;
using System.Collections.Generic;
using System.Text;
using ITPM.Database;

namespace ITPM.Repository
{
    internal class DatabaseManager
    {
        private static readonly ITPMContext databaseContext;

        // Initialize and open the database connection
        static DatabaseManager()
        {
            databaseContext = new ITPMContext();
        }

        // Provide an accessor to the database
        public static ITPMContext Instance
        {
            get
            {
                return databaseContext;
            }
        }
    }
}
