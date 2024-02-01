namespace Exercicio2;

public class Post
{
    public DateTime Moment { get; set;}
    public string Title { get; set; }
    public string Content { get; set; }
    public int Likes { get; set; }

    public List<Comment> Comments { get; set; } = new List<Comment>();

    public Post(string title, string content, int likes) { 
        Moment = DateTime.Now;
        Title = title;
        Content = content;
        Likes = likes;
    }

    public override string ToString() {
        string text = $"{Title}\n{Likes} - {Moment}\n{Content}\nComments:\n";
        foreach(Comment c in Comments) {
            text += $"{c.Text}\n";
        }
        return text;
    }
}
