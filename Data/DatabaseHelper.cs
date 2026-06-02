using System;
using System.IO;

namespace MovieDB.Data
{
    internal static class DatabaseHelper
    {
        private const string DatabaseFileName = "Database.accdb";

        public static string ConnectionString =>
            $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DatabasePath};Persist Security Info=False;";

        private static string DatabasePath =>
            Path.Combine(AppContext.BaseDirectory, DatabaseFileName);
    }
}
