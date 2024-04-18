using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Practical2
{
    public class DB
    {
        private readonly SQLiteConnection conn;

        public DB(string path)
        {
            conn = new SQLiteConnection(path);
            conn.CreateTable<Users>();
        }

        public List<Users> GetUsers()
        {
            return conn.Table<Users>().ToList();
        }

        public int SaveUser(Users user)
        {
            return conn.Insert(user);
        }
    }
}
