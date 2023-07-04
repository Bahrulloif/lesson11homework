public class PhotoBook
{
    private int _numPages;
    public int GetNumberPages()
    {
        return _numPages;
    }
    public PhotoBook()
    {
        _numPages = 16;
    }
    public PhotoBook(int numPages)
    {
        _numPages = numPages;
    }
    
}