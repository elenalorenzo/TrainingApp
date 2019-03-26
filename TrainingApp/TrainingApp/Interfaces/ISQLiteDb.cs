using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TrainingApp.Interfaces
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
