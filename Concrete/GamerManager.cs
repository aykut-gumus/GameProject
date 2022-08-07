using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _userValidationService;

        public GamerManager()
        {

        }

        public GamerManager(IGamerCheckService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer1)
        {
              if (_userValidationService.CheckIfRealPerson(gamer1))
            {
                Console.WriteLine(gamer1.FirstName + " " + gamer1.LastName + " " + "sisteme kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Kişi bilgisi doğrulanamadı. Kayıt başarısız.");
            }
        }
        public void Delete(Gamer gamer3)
        {
            Console.WriteLine(gamer3.FirstName + " " + gamer3.LastName + " " + "sistemden kaydı silindi.");
        }

        public void Update(Gamer gamer2)
        {
            Console.WriteLine(gamer2.FirstName + " " + gamer2.LastName + " " + "kaydı güncellendi.");
        }
    }
}
