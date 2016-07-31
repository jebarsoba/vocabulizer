using DAL;
using Phoneword.Droid;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteConnection_Android))]

namespace Phoneword.Droid
{
    public class SQLiteConnection_Android : ISQLiteConnection
    {
        const string sqliteFilename = "vocabulizer.db3";

        public SQLite.SQLiteConnection GetConnection()
        {
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            return new SQLite.SQLiteConnection(Path.Combine(documentsPath, sqliteFilename));
        }
    }
}