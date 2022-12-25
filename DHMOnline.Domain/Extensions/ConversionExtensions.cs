using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.Domain.Extensions
{
    public static class ConversionExtensions
    {
        // ToInt - Verilen stringi integera cast eder
        public static int ToInt(this string s, int defVal = 0)
        {
            var res = defVal;
            var sonuc = int.TryParse(s, out res);

            return sonuc ? res : defVal;
        }

        // ToLong - Verilen stringi integera cast eder
        public static long ToLong(this string s, long defVal = 0)
        {
            var res = defVal;
            var sonuc = long.TryParse(s, out res);

            return sonuc ? res : defVal;
        }

        // ToByteArray - stringi byteArraya dönüştürür
        public static byte[] ToByteArray(this string str)
        {
            UTF8Encoding encoding = new UTF8Encoding();

            return encoding.GetBytes(str);
        }
    }
}
