using GameSimulator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Concrete
{
    public class MemberManager : IOperationService
    {
        public void Add()
        {
            Console.WriteLine("member added");
        }

        public void Delete()
        {
            Console.WriteLine("member deleted");
        }

        public void Update()
        {
            Console.WriteLine("member updated");
        }
    }
}
