using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public static class MySupportMethods
    {
        public static string StrMoneyToStrCurrency(string str)
        {
            StringBuilder sb = new StringBuilder();

            while (str.Length > 0)
            {
                string temp = "";
                if (str.Length > 3)
                {
                    temp = "." + str.Substring(str.Length - 3, 3);
                    str = str.Substring(0, str.Length - 3);
                }
                else
                {
                    temp = str;
                    str = "";
                }

                sb.Insert(0, temp);
            }

            return sb.ToString();
        }

        public static int StrCurrencyToInt(string str)
        {
            int res = 0;
            try
            {
                res = int.Parse(str.Replace(".", string.Empty));
            }
            catch(Exception ex)
            {
                return -1;
            }
            return res;
        }

        public static Image ResizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)b);

            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();

            return (Image)b;
        }

        public static bool isNumberic(string str)
        {
            if (str.Length == 0)
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (!(str[i] >= '0' && str[i] <= '9'))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
