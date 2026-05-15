using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKDequipShop.Domains.Entities.Refs;
using TKDequipShop.Domains.Enums.User;


namespace TKDequipShop.Domains.Entities.User
{
    public class UserData : SharedFields
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        //public AddressData? DefaultAddress { get; set; }
        public PaymentMethods? DefaultPaymentMethod { get; set; }
        public DateTime DOB { get; set; }
        public GenderTypes Gender { get; set; }
        public bool IsActive { get; set; } 
    }
}
