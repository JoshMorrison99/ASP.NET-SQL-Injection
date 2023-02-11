using VulnASP.NET_API.Data;
using VulnASP.NET_API.Models;

namespace VulnASP.NET_API
{
    public class Seed
    {
        private readonly DataContext dataContext;

        public Seed(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void SeedDataContext()
        {
            if (!dataContext.Users.Any())
            {
                var User1 = new User
                {
                    UserName = "shelled",
                    Password = "myPassword123!",
                    FavouriteColor = "Orange"
                };
                var User2 = new User
                {
                    UserName = "howard",
                    Password = "chevrolet",
                    FavouriteColor = "Red"
                };
                var User3 = new User
                {
                    UserName = "orelia",
                    Password = "deutsch",
                    FavouriteColor = "Red"
                };
                var User4 = new User
                {
                    UserName = "minoru",
                    Password = "maxxxx",
                    FavouriteColor = "Green"
                };
                var User5 = new User
                {
                    UserName = "accounting",
                    Password = "asdfgh",
                    FavouriteColor = "Green"
                };
                var User6 = new User
                {
                    UserName = "sadan",
                    Password = "gen45",
                    FavouriteColor = "Purple"
                };
                var User7 = new User
                {
                    UserName = "ryszard",
                    Password = "foundly76",
                    FavouriteColor = "Yellow"
                };
                var User8 = new User
                {
                    UserName = "scott",
                    Password = "greem23",
                    FavouriteColor = "Blue"
                };
                dataContext.Users.Add(User1);
                dataContext.Users.Add(User2);
                dataContext.Users.Add(User3);
                dataContext.Users.Add(User4);
                dataContext.Users.Add(User5);
                dataContext.Users.Add(User6);
                dataContext.Users.Add(User7);
                dataContext.Users.Add(User8);
                dataContext.SaveChanges();
            }
        }
    }
}
