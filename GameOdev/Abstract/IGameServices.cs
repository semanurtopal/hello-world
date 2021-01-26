using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Abstract
{
    public interface IGameServices
    {
        void Buy(IEntity game, IEntity player);
    }
}
