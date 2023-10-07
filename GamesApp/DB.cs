using MySql.Data.MySqlClient;


namespace GamesApp
{
    internal class DB
    {
        MySqlConnection db = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=gameapp");
        public void OpenConnection()
        {
            if(db.State == System.Data.ConnectionState.Closed)
                db.Open();
        }
        public void CloseConnection()
        {
            if (db.State == System.Data.ConnectionState.Open)
                db.Close();
        }
        public MySqlConnection GetConnection()
        {
            return db;
        }
    }
}
