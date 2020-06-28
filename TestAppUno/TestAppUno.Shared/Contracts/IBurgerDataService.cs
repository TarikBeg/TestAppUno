using System.Collections.Generic;
using TestAppUno.Model;

namespace TestAppUno.Contracts
{
    public interface IBurgerDataService
    {
        List<Burger> GetAllBurgers();

        List<BurgerGroup> GetGroupedBurgers();

        List<Burger> GetBurgersForGroup(int burgerGroupId);

        List<Burger> GetFavoriteBurgers();

        Burger GetBurgerById(int burgerId);
    }
}
