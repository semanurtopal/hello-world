using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Abstract
{
    public interface IGamerService
    {
        void Save(IEntity gamer);
        void Update(IEntity gamer);
        void Delete(IEntity gamer);
    }
}
