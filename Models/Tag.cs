namespace TheBlogProject.Models
{
    public class Tag
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public string Name { get; set; }

        public Post Post { get; set; }
    }
}
