namespace DocumentManager.Domain.library;

public class DocumentItem
{
    public string Title { get; set; }
    public string Content { get; set; }
    
    public DocumentItem(string title, string content)
    {
        this.Title = title;
        this.Content = content;
    }
}