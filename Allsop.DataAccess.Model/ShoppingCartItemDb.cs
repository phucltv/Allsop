using Allsop.DataAccess.Model.Base;

namespace Allsop.DataAccess.Model
{
    public class ShoppingCartItemDb : BaseEntityDb
    {
        public Guid ShoppingCartId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
    }
}
