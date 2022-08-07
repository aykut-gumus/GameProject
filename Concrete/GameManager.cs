using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game1)
        {
            Console.WriteLine(game1.GameName + " " + "eklendi.");
        }

        public void Update(Game game2)
        {
            Console.WriteLine(game2.GameName + " " + "güncellendi.");
        }

        public void Delete(Game game3)
        {
            Console.WriteLine(game3.GameName + " " + "silindi.");
        }

    }
}
