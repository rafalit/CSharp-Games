using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Snake
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("Assets/Empty.png");
        public readonly static ImageSource Food = LoadImage("Assets/Food.png");
        public readonly static ImageSource Head = LoadImage("Assets/Head.png");
        public readonly static ImageSource DeadHead = LoadImage("Assets/DeadHead.png");
        public readonly static ImageSource DeadBody = LoadImage("Assets/DeadBody.png");
        public readonly static ImageSource Body = LoadImage("Assets/Body.png");

        private static ImageSource LoadImage(string fileName)
        {
            try
            {
                var uri = new Uri(fileName, UriKind.Relative);
                return new BitmapImage(uri);
            }
            catch (Exception ex)
            {
                // Handle the exception or log it
                Console.WriteLine($"Error loading image '{fileName}': {ex.Message}");
                // Return a default image or null, depending on your preference
                return null;
            }
        }

    }
}
