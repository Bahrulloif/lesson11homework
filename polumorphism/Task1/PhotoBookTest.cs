public class PhotoBookTest
{
    public void DefaultPhotoBook() {
        PhotoBook book = new PhotoBook();
        System.Console.WriteLine(book.GetNumberPages());
    }
    
    public void PhotoBook24() {
        PhotoBook book = new PhotoBook(24);
        System.Console.WriteLine(book.GetNumberPages());
    }
    
    public void LargePhotoBook() {
        PhotoBook book = new BigPhotoBook();
        System.Console.WriteLine(book.GetNumberPages());
    }
}