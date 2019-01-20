using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage ="Укажите ваше имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Адрес доставки")]
        [Display(Name ="Первый адрес")]
        public string Line1 { get; set; }
        [Display(Name = "Второй адрес")]
        public string Line2 { get; set; }
        [Display(Name = "Третий адрес")]
        public string Line3 { get; set; }

        [Display(Name = "Город")]
        [Required(ErrorMessage = "Укажите город")]
        public string City { get; set; }

        [Display(Name = "Страна")]
        [Required(ErrorMessage = "Укажите страну")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
