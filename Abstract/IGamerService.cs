using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer1);
        void Update(Gamer gamer2);
        void Delete(Gamer gamer3);
    }
}
