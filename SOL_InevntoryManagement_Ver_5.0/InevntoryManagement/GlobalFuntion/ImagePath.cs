using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.GlobalFuntion
{
    public class ImagePath
    {


        public static string GetProductImagePath(string imageName=null)
        {
            string path = "";
            if(imageName==null)
            {
                path = "Projects/Images/Product";
            }
            else
            {
                path = "Projects/Images/Product/" + imageName;
            }
            return path;

        }


        public static string GetDefaultImagePath(string imageName = null)
        {
            string path = "";
            if (imageName == null)
            {
                path = "Projects/Images/DefaultImage";
            }
            else
            {
                path = "Projects/Images/DefaultImage/" + imageName;
            }
            return path;

        }

        public static string GetBlankImageFromRootFolder()
        {
            return "~/Projects/Images/DefaultImage/No_Image_Available.jpg";
        }
    }
}
