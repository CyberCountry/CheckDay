using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace CheckDays.DatebaseClases
{
    [Table("CheckersList")]
    public class CreareDateBase
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Text { get; set; }
        public string Type { get; set; }
        public DateTime Time_start { get; set; }
        public DateTime Time_end { get; set; }
    }
}
