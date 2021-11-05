using GameSimulator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Abstract
{
    public interface IMemberCheckService
    {
        bool CheckIfRealMember(Member member);
    }
}
