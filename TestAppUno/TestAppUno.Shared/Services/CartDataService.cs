using TestAppUno.Contracts;
using TestAppUno.Model;
using TestAppUno.Repositories;

namespace TestAppUno.Services
{
    public class CartDataService : ICartDataService
    {
        private static readonly CartRepository CartRepository = new CartRepository();

        public void AddCartItem(Burger burger, int amount)
        {
            CartRepository.AddCartItem(burger, amount);
        }

        public Cart GetCart()
        {
            return CartRepository.GetCart();
        }
    }
}