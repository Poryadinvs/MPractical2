using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Practical2
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string LasyName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
