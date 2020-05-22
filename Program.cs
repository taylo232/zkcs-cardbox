using System;
using System.Data.SQLite;


namespace zkcs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            string cs = "Data Source=:memory:";
            string stm = "SELECT SQLITE_VERSION()";

            using var db = new SQLiteConnection(cs);
            db.Open();

            using var cmd = new SQLiteCommand(stm, db);
            string version = cmd.ExecuteScalar().ToString();

            Console.WriteLine($"SQLite version: {version}");
            db.Close();


        }
    }
}
