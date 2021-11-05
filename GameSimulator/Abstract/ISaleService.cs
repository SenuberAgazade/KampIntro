using GameSimulator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Abstract
{
    public interface ISaleService
    {
        void CalculateSaleAmountWithCampaign(Member member, Sale sale, Campaign campaign);
        void CalculateSaleAmountWithoutCampaign(Member member, Sale sale);
    }
}
