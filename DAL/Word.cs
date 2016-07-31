using SQLite;

namespace DAL
{
    [Table("Word")]
    public class Word
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string source { get; set; }
        public string target { get; set; }
    }
}