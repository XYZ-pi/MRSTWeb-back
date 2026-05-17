using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Cart;
using TKDequipShop.Domains.Entities.Order;
using TKDequipShop.Domains.Entities.Refs;
using TKDequipShop.Domains.Enums.User;


namespace TKDequipShop.Domains.Entities.User
{
    public class UserData : SharedFields
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string UserName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        //public AddressData? DefaultAddress { get; set; }
        public PaymentMethods? DefaultPaymentMethod { get; set; }
        public DateTime DOB { get; set; }
        public GenderTypes Gender { get; set; }
        public bool IsActive { get; set; }
        public CartData? Cart { get; set; }
        public List<OrderData> Orders { get; set; } = new List<OrderData>();
    }
}
