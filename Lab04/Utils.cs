using System.Globalization;

namespace Lab04
{
    internal class Utils
    {
        private static readonly ImageConverter _imageConverter = new();
        public static byte[] ImageToByteArray(Image image)
        {
            using MemoryStream ms = new();
            image.Save(ms, image.RawFormat);
            byte[] imageBytes = ms.ToArray();

            return ms.ToArray();
        }

        public static Bitmap? ByteArrayToImage(byte[] byteArray)
        {

            Bitmap? bm = _imageConverter.ConvertFrom(byteArray) as Bitmap;

            if (bm != null && (bm.HorizontalResolution != (int)bm.HorizontalResolution ||
                               bm.VerticalResolution != (int)bm.VerticalResolution))
            {
                // Correct a strange glitch that has been observed in the test program when converting 
                //  from a PNG file image created by CopyImageToByteArray() - the dpi value "drifts" 
                //  slightly away from the nominal integer value
                bm.SetResolution((int)(bm.HorizontalResolution + 0.5f),
                                 (int)(bm.VerticalResolution + 0.5f));
            }

            return bm;
        }

        public static List<string> GetCountryList()
        {
            List<string> cultureList = new();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new(culture.LCID);

                if (!(cultureList.Contains(region.EnglishName)))
                {
                    cultureList.Add(region.EnglishName);
                }
            }
            return cultureList;
        }
    }
}
