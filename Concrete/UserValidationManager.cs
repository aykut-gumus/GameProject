using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class UserValidationManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.DateOfBirth == 1992 && gamer.FirstName == "Fatih" &&
                    gamer.LastName == "Hasır" && gamer.NationalityId == 12345678910)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
