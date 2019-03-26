using System;
using System.IO;
using SQLite;
using TrainingApp.Droid;
using TrainingApp.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]
namespace TrainingApp.Droid
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var docsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(docsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}