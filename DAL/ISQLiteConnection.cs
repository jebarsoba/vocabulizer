using SQLite;

namespace DAL
{
    public interface ISQLiteConnection
    {
        SQLiteConnection GetConnection();
    }
}