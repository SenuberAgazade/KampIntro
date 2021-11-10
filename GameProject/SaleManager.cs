using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class SaleManager : ISaleService
    {
        public void MakeSale(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine($"gamer name : {gamer.FirstName} {gamer.LastName} with {campaign.Discount}% discount of campaign {campaign.CampaignName}");
        }
    }
}
