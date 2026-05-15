using System.Security.Cryptography.X509Certificates;
using TKDequipShop.BusinessLogic.Interfaces;
using TKDequipShop.BusinessLogic.Functions;

namespace TKDequipShop.BusinessLogic
{
    public class BusinessLogic
    {
        public BusinessLogic()
        {
        }

        public IProductActions GetProductActions()
        {
            return new ProductFlow();
        }

        public IUserActions GetUserActions()
        {
            return new UserFlow();
        }
    }
}
