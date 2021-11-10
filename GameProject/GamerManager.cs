using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Gamer added");
            }
            else
            {
                Console.WriteLine("user validation is not valid");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated");
        }
    }
}
