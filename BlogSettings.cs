namespace meg_blog
{
    public class BlogSettings
    {
        public string Name { get; set; } = "meg_blog";
        public string Description { get; set; } = "A place to meet new people and discover new food over amazing conversation.";
        public string Owner { get; set; } = "Megan Miedema";
        public int PostsPerPage { get; set; } = 2;
        public int CommentsCloseAfterDays { get; set; } = 10;
    }
}
