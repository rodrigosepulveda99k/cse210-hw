public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string commentText)
    {
        comments.Add(new Comment(commenterName, commentText));
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetAllComments()
    {
        return comments;
    }
}