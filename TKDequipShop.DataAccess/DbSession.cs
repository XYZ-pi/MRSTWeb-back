namespace TKDequipShop.DataAccess
{
    public class DbSession
    {
        public static string ConnectionString { get; set; } = "Server=localhost;Database=TKDequipShop;Trusted_Connection=True;TrustServerCertificate=True;";
    }
}