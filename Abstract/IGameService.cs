﻿using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IGameService
    {
        void Add(Game game1);
        void Update(Game game2);
        void Delete(Game game3);
    }
}
