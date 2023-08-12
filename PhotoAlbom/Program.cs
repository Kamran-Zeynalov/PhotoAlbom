using System.Reflection.PortableExecutable;

namespace PhotoAlbom
{
    public class PhotoBook
    {
        private int NumPages { get; set; }

        public PhotoBook(int numPages)
        {
            NumPages = numPages;
        }
        public PhotoBook()
        {
            int specifyNum = 5;
            if (specifyNum > NumPages) return;
            NumPages = specifyNum;
        }

        public int GetNumberPages()
        {
            return NumPages;
        }
    }

    public class BigPhotoBook
    {
        public int NumPages { get; set; }
        public BigPhotoBook(int numPages)
        {

            NumPages = numPages;

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            PhotoBook phBook = new(6);
            PhotoBook phBook24Pages = new(24);
            BigPhotoBook bigPhBook = new BigPhotoBook(64);

            int pages1 = phBook.GetNumberPages();
            int pages2 = phBook24Pages.GetNumberPages();
            int bigPhBookPages = bigPhBook.NumPages;

            Console.WriteLine("A default PhotoBook's number of pages: " + pages1);
            Console.WriteLine("A PhotoBook with " + pages2 + " pages");
            Console.WriteLine("A large PhotoBook's number of pages: " + bigPhBookPages);
        }
    }
}