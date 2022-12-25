// Bu class, string methodlarını içerir, Util mantığında çalışır


// extension method yazma adımları
// 1. class static olacak
// 2. methodlar static olacak
// 3. method parametrelerinin ilk parametresi this keywordu ile başlayacak
// * methodlar genellikle Is, Has, Can, To gibi prefixler ile başlaması tavsiye edilir.

namespace DHMOnline.Domain.Extensions
{
    public static class StringExtensions
    {
        // IsNullOrEmpty - string boş mu null mu kontrolü yapar
        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        // ToTrimInline
        public static string ToTrimInline(this string s)
        {
            // * Tüm string alan parametrelerimizde mutlaka nullcheck yapmalıyız
            if (s.IsNullOrEmpty()) return s;

            return s.Trim().Replace(" ", "");
        }
    }
}
