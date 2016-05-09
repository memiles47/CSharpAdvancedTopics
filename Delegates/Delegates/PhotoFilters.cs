using System;

namespace Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            //Apply Brightness Filter
            Console.WriteLine("Brightness Filter Applied");
        }

        public void ApplyContrast(Photo photo)
        {
            //Apply Contrast Filter
            Console.WriteLine("Contrast Filter Applied");
        }

        public void Resize(Photo photo)
        {
            //Resize Photo
            Console.WriteLine("Photo resized");
        }
    }
}