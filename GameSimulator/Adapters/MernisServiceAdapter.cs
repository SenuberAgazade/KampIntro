using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSimulator.Abstract;
using GameSimulator.Entity;
using GameSimulator.MernisServiceReference;

namespace GameSimulator.Adapters
{
    public class MernisServiceAdapter : IMemberCheckService
    {
        public bool CheckIfRealMember(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return 
                client.TCKimlikNoDogrula(Convert.ToInt64(member.TcNo),member.FirstName.ToUpper(),member.LastName.ToUpper(),member.DateOfBirth.Year);
        }
    }
}
