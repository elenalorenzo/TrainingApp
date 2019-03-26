using System;
using System.IO;
using SQLite;
using TrainingApp.iOS;
using TrainingApp.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]

namespace TrainingApp.iOS
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