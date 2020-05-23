using System;
using System.Data.SQLite;


namespace zkcs
{
    class Program
    {
        static void Main()
        {

           string cs = @"URI=file:..\..\..\zkcs.db";

            using var db = new SQLiteConnection(cs);
            db.Open();

            string stm = "SELECT * FROM zkcsmain";

            using var cmd = new SQLiteCommand(stm, db);
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine($"{rdr.GetName(0)}    |{rdr.GetName(1)}    |{rdr.GetName(2)}    |{rdr.GetName(3)}    |{rdr.GetName(4)}    |{rdr.GetName(5)}    |{rdr.GetName(6)}");

            while (rdr.Read())
            {
                Console.WriteLine($"{rdr.GetString(0)}|{rdr.GetString(1)}|{rdr.GetString(2)}|{rdr.GetString(3)}|{rdr.GetString(4)}|{rdr.GetString(5)}|{rdr.GetString(6)}");
            }

            db.Close();

        }
    }
}
