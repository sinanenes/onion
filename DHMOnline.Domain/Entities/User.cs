using DHMOnline.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace DHMOnline.Domain.Entities
{
    public class User : EntityBase
    {
        [Display(Name = "User Key")]
        [Key]
        public int UserKey { get; set; }

        [Display(Name = "Sicil No")]
        [StringLength(10)]
        [Required(ErrorMessage = "Lütfen Sicil No Giriniz!")]
        public string UserSicilNo { get; set; }

        [Display(Name = "Ad Soyad")]
        [StringLength(50)]
        [Required(ErrorMessage = "Lütfen Parola Giriniz!")]
        public string UserPassword { get; set; }

    }
}
