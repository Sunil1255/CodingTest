using System;
using SQLite;

namespace WhetherPOC.Models
{
    public class WhetherDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string name { get; set; }

        public string country { get; set; }

        public override string ToString()
        {
            return string.Format("City : {0}    |     Country : {1}", name, country);
        }
    }
}
