using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                Id = 1,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                BirthYear = 1985,
                IdentityNumber = 12345
            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);

            Campaign campaign = new Campaign
            {
                Id = 1,
                CampaignName = "BlackFriday",
                Discount = 60
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);


            SaleManager saleManager = new SaleManager();
            saleManager.MakeSale(gamer, campaign);

            Console.ReadKey();
        }
    }
}
