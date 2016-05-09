using System;

namespace Delegates
{
    class Program
    {
        static void Main()
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            //Apply Brightness Filter
            Console.WriteLine("Remove RedEye Filter Applied");
        }
    }
}
