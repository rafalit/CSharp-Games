using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Snake
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("Resources/Empty.png");
        public readonly static ImageSource Food = LoadImage("Resources/Food.png");
        public readonly static ImageSource Head = LoadImage("Resources/Head.png");
        public readonly static ImageSource DeadHead = LoadImage("Resources/DeadHead.png");
        public readonly static ImageSource DeadBody = LoadImage("Resources/DeadBody.png");
        public readonly static ImageSource Body = LoadImage("Resources/Body.png");

        private static ImageSource LoadImage(string fileName)
        {
            var uri = new Uri(fileName, UriKind.Relative);
            return new BitmapImage(uri);
        }
    }
}
