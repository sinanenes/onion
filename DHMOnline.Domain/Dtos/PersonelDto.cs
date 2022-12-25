using DHMOnline.Domain.Dtos.Base;
using System.ComponentModel.DataAnnotations;

namespace DHMOnline.Domain.Dtos
{
    public class PersonelDto : DtoBase
    {
        [Display(Name = "Personel Key")]
        [Key]
        public int PersonelKey { get; set; }

        [Display(Name = "TC Kimlik No")]
        [Required(ErrorMessage = "Lütfen TC Kimlik No Giriniz!")]
        public string TCKimlikNo { get; set; }

        [Display(Name = "Ad Soyad")]
        [StringLength(50)]
        [Required(ErrorMessage = "Lütfen Ad Soyad Giriniz!")]
        public string AdSoyad { get; set; }

        [Display(Name = "Maaş")]
        public decimal? Maas { get; set; }
    }
}
