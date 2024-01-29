namespace DocumentManager.Domain.library;

public class Document_Manager
{
    private readonly Queue<DocumentItem> documentQueue = new Queue<DocumentItem>();
    
    public void AddDocument()
    {
        documentQueue.Enqueue(new DocumentItem("Test Title", "Test Content"));
    }
    
    public DocumentItem GetNextInQueue()
    {
        DocumentItem documentItem = null;
        
        return documentItem;
    }
    
    public DocumentItem ProcessNextDocumentInQueue()
    {
        DocumentItem documentItem = null;
        
        return documentItem;
    }
    
    public bool IsDocumentAvailable(string title)
    {
        return false;
    }

    public int CountItemsInQueue()
    {
        return documentQueue.Count;
    }
}