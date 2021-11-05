using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSimulator.Abstract;
using GameSimulator.Entity;

namespace GameSimulator.Concrete
{
    public class SaleManager : ISaleService
    {
        private IMemberCheckService _memberCheckService;
        public SaleManager(IMemberCheckService memberCheckService)
        {
            _memberCheckService = memberCheckService;
        }

        public void CalculateSaleAmountWithCampaign(Member member, Sale sale, Campaign campaign)
        {
            if (_memberCheckService.CheckIfRealMember(member))
            {
                int saleAmount = (sale.Quantity * sale.Price * campaign.Discount) / 100;
                Console.WriteLine($"sale amount for {member.FirstName} {member.LastName} member : {saleAmount}");
            }
            else
            {
                throw new Exception("not a valid member");
            }
            
        }

        public void CalculateSaleAmountWithoutCampaign(Member member, Sale sale)
        {
            if (_memberCheckService.CheckIfRealMember(member))
            {
                int saleAmount = (sale.Quantity * sale.Price) / 100;
                Console.WriteLine($"sale amount for {member.FirstName} {member.LastName} member : {saleAmount}");
            }
            else
            {
                throw new Exception("not a valid member");
            }
        }
    }
}
