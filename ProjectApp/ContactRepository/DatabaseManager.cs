using devTimecardDB;

namespace TimecardRepository
{
    public static class DatabaseManager
    {
        private static readonly devTimecardDBContext entities;

        // Initialize and open the database connection
        static DatabaseManager()
        {
            entities = new devTimecardDBContext();
        }

        // Provide an accessor to the database
        public static devTimecardDBContext Instance
        {
            get
            {
                return entities;
            }
        }
    }
}