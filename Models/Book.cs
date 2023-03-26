namespace FirstApp.Models
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int? PageNumber { get; set; }
    }
}
