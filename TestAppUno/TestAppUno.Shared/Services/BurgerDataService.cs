using System.Collections.Generic;
using TestAppUno.Contracts;
using TestAppUno.Model;
using TestAppUno.Repositories;

namespace TestAppUno.Services
{
    public class BurgerDataService: IBurgerDataService
    {
        private static readonly BurgerRepository BurgerRepository = 
            new BurgerRepository();

        public List<Burger> GetAllBurgers()
        {
            return BurgerRepository.GetAllBurgers();
        }

        public List<BurgerGroup> GetGroupedBurgers()
        {
            return BurgerRepository.GetGroupedBurgers();
        }

        public List<Burger> GetBurgersForGroup(int burgerGroupId)
        {
            return BurgerRepository.GetBurgersForGroup(burgerGroupId);
        }

        public List<Burger> GetFavoriteBurgers()
        {
            return BurgerRepository.GetFavoriteBurgers();
        }

        public Burger GetBurgerById(int burgerId)
        {
            return BurgerRepository.GetBurgerById(burgerId);
        }
    }
}
