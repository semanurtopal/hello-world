using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(IEntity gamer);
    }
}
