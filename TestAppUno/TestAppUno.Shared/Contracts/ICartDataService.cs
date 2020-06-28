using TestAppUno.Model;

namespace TestAppUno.Contracts
{
    public interface ICartDataService
    {
        void AddCartItem(Burger burger, int amount);
        Cart GetCart();
    }
}