namespace SmartQuiz.Helper
{
    public enum Formats { png,jpg,undefinedformat}
    public static class ImageHelper
    {
        public static Formats CheckImageExtension(string Base64)
        {
            var ImageFormat = Base64.Split(';')[0];
            if (ImageFormat == "data:image/png")
            {
                return Formats.png;
            }
            else if (ImageFormat == "data:image/jpg" || ImageFormat== "data:image/jpeg")
            {
                return Formats.jpg;
            }

            return Formats.undefinedformat;
        }
        public static string? GetImageExtension(Formats format)
        {
            if(format == Formats.png)
            {
                return ".png";
            }
            else if (format == Formats.jpg)
            {
                return ".jpg";
            }
            else
            {
                return null;
            }
        }


    }
}
