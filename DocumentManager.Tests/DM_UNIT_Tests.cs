
using DocumentManager.Domain.library;

namespace DocumentManager.Tests;

[TestFixture]
public class DocumentManagerTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DemoTestShouldPass()
    {
        Assert.Pass();
    }

    [Test]
    public void DocumentShouldReturnTitle()
    {
        var titleToTest = "Test Title";
        var contentToTest = "Test Content";
        
        var documentItem = new DocumentItem(titleToTest, contentToTest);
        
        Assert.That(documentItem.Content, Is.EqualTo(contentToTest));
    }

    [Test]
    public void DocumentManagerShouldAddItemToQueue()
    {
        Assert.Fail();
    }
    
    [Test]
    public void DocumentManagerShouldReturnFirstItemInQueue()
    {
        Assert.Fail();
    }
    
    [Test]
    public void DocumentManager_IsDocumentAvailable_ShouldReturnFalseWhenQueueIsEmpty()
    {
        Assert.Fail();
    }
    
    [Test]
    public void DocumentManager_IsDocumentAvailable_ShouldReturnTrueWhenQueueIsNotEmpty()
    {
        Assert.Fail();
    }
    
    [Test]
    public void DocumentManager_CountItemsInQueue_ShouldReturnCorrectCount()
    {
        
    }
}